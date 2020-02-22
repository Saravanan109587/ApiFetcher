using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        public async void fetchAPi(string url)
        {        
            object request=null;
            using (HttpClient client = new HttpClient())
            {
                JsonSerializerSettings dateFormat = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
                 
                using (var httpContent = request != null ? new StringContent(JsonConvert.SerializeObject(request, dateFormat), Encoding.UTF8, "application/json") : null)

                using (var webResponse = await client.PostAsync(url, httpContent))
                {
                    var content = await webResponse.Content.ReadAsStringAsync();
                    
                    try
                    { 
                            var con = JsonConvert.DeserializeObject(content).ToString();
                        txt_response.Text = con;
                             
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }                  
                }
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            fetchAPi(txt_connection.Text);
        }
    }
}
