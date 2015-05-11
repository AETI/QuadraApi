using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace QuadraApi.WinForm
{
    /// <summary>
    /// Quadra API sample main form
    /// </summary>
    public partial class Main : Form
    {

        #region Private Variables 

        // Aquired at login and passed to subsequent API calls
        private string _accessToken = string.Empty;

        #endregion

        #region Ctor

        public Main()
        {
            InitializeComponent();
            responseTypeComboBox.SelectedIndex = 0;
        }

        #endregion

        #region Event Handlers

        private void loginButton_Click(object sender, EventArgs e)
        {
            GetAccessToken();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            GetData("/api/items");
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            GetData("/api/otherexposures");
        }

        private void structuresButton_Click(object sender, EventArgs e)
        {
            GetData("/api/structures");
        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            GetData("/api/vehicles");
        }
        
        #endregion

        #region Private Implementation

        /// <summary>
        /// Retreive an access token from Quadra API, this token is then passed in subsequent requests for authentication
        /// </summary>
        private void GetAccessToken()
        {
            var responseText = string.Empty;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Format form data - example:  grant_type=password&userName=jdoe@fake.net&password=abc123
                var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>( "grant_type", "password" ), 
                    new KeyValuePair<string, string>( "userName", userNameTextBox.Text ), 
                    new KeyValuePair<string, string> ( "password", passwordTextBox.Text )
                };
                var content = new FormUrlEncodedContent(pairs);

                // Perform POST on Quadra API
                using (var client = new HttpClient())
                {
                    // Get response
                    var response = client.PostAsync(quadraUrlTextBox.Text + "/api/token", content).Result;
                    responseText = response.Content.ReadAsStringAsync().Result;                    
                }

                // Serialize json and get access token
                var serializer = new JavaScriptSerializer();
                dynamic authResult = serializer.Deserialize<dynamic>(responseText);

                // Confirm there is a token
                if (authResult == null || !authResult.ContainsKey("access_token") || authResult["access_token"] == null)
                    throw new Exception(responseText);

                // Set the token
                _accessToken = authResult["access_token"].ToString();
                
                // Update UI
                loginPanel.Hide();
                dataPanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

          
        }

        /// <summary>
        /// Get export data from the input url
        /// </summary>
        /// <param name="dataUrl">Relative Quadra API url to retreieve data from</param>
        /// <param name="responseType">Possible response types include: application/xml application/json </param>
        private void GetData(string dataUrl)
        {
            var responseText = string.Empty;
            var responseType = string.Empty;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Clear display
                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();

                // Get response type based on selected combo value
                switch(responseTypeComboBox.SelectedItem.ToString())
                {
                    case "JSON":
                        responseType = "application/json";
                        break;
                    case "XML":
                        responseType = "application/xml";
                        break;
                }

                
                // Perform GET on Quadra API
                using (var c = new HttpClient())
                {
                    // Add auth header
                    c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

                    // Specify the response type
                    c.DefaultRequestHeaders.Add("Accept", responseType);                    

                    // Get response
                    var response = c.GetAsync(quadraUrlTextBox.Text + dataUrl).Result;
                    responseText = response.Content.ReadAsStringAsync().Result;                                        
                }

                // Process response
                switch (responseType)
                {
                    case "application/json":
                        LoadGridJson(responseText);
                        break;
                    case "application/xml":
                        LoadGridXml(responseText);
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        /// <summary>
        /// Serialize json and populate the results grid
        /// </summary>
        /// <param name="json"></param>
        private void LoadGridJson(string json)
        {    

            // Serialize json
            var serializer = new JavaScriptSerializer() { MaxJsonLength = int.MaxValue };
            dynamic data = serializer.Deserialize<dynamic>(json);

            // Invalid result parsed as dictionary containing json error
            if (data is Dictionary<string, object>)
                throw new Exception(json);

            // Output results
            if (data != null && data.Length > 0)
            {
                // Setup columns
                Dictionary<string, object> row = data[0];
                foreach (var column in row.Keys)
                {
                    dataGridView.Columns.Add(new DataGridViewColumn()
                    {
                        HeaderText = column,                        
                        CellTemplate = new DataGridViewTextBoxCell(),
                        ReadOnly = true
                    });
                }

                // Add data to grid
                for (var rowIndex = 0; rowIndex < data.Length; rowIndex++)
                {
                    row = data[rowIndex];
                    dataGridView.Rows.Add(row.Values.ToArray());
                }
            }
        }

        /// <summary>
        /// Read xml into a datatable and populate the results grid
        /// </summary>
        /// <param name="xml"></param>
        private void LoadGridXml(string xml)
        {
            var dataTable = new DataTable();

            // Fill data table
            dataTable.BeginLoadData();
            using (var reader = new StringReader(xml))            
                dataTable.ReadXml(reader);            
            dataTable.EndLoadData();
                        
            // Output results
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Setup columns                
                foreach (DataColumn column in dataTable.Columns)
                {
                    dataGridView.Columns.Add(new DataGridViewColumn()
                    {                        
                        HeaderText = column.Caption,
                        ValueType = column.DataType,
                        CellTemplate = new DataGridViewTextBoxCell(),
                        ReadOnly = true
                    });
                }

                // Add data to grid
                for (var rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
                {
                    var row = dataTable.Rows[rowIndex];
                    dataGridView.Rows.Add(row.ItemArray);
                }
            }
        }

        #endregion

    }
}
