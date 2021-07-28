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
using IdentityModel.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Myxy.NET.IdS4.Tester
{
    public partial class Form1 : Form
    {
        private ClientCredentialView clientCredentialView = new ClientCredentialView();
        private ResourceView resourceView = new ResourceView();
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckClientCredentialParameters()
        {
            if (!string.IsNullOrWhiteSpace(txtIdentityServer.Text))
            {
                clientCredentialView.IdentityServer = txtIdentityServer.Text.Trim();
            }

            if (!string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                clientCredentialView.ClientId = txtClientId.Text.Trim();
            }

            if (!string.IsNullOrWhiteSpace(txtClientSecret.Text))
            {
                clientCredentialView.ClientSecret = txtClientSecret.Text.Trim();
            }

            if (!string.IsNullOrWhiteSpace(txtApiScopes.Text))
            {
                clientCredentialView.ApiSAcopes = txtApiScopes.Text.Trim();
            }
        }

        private bool CheckResourceParameters()
        {
            if (!string.IsNullOrWhiteSpace(txtToken.Text))
            {
                resourceView.Token = txtToken.Text.Trim();
            }
            else
            {
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtApi.Text))
            {
                resourceView.Api = txtApi.Text.Trim();
            }
            else
            {
                return false;
            }

            return true;
        }

        private async void btnAuthenticate_Click(object sender, EventArgs e)
        {
            CheckClientCredentialParameters();

            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync(clientCredentialView.IdentityServer);
            if (disco.IsError)
            {
                this.txtTokenList.Text = disco.Error;
                return;
            }

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = clientCredentialView.ClientId,
                ClientSecret = clientCredentialView.ClientSecret,
                Scope = clientCredentialView.ApiSAcopes
            });

            if (tokenResponse.IsError)
            {
                txtTokenList.Text = tokenResponse.Error;
                return;
            }

            txtTokenList.Text = JsonConvert.SerializeObject(tokenResponse.Json);
            txtToken.Text = tokenResponse.AccessToken;

        }

        public class ClientCredentialView
        {
            public string IdentityServer { get; set; }
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string ApiSAcopes { get; set; }
        }

        public class ResourceView
        {
            public string Token { get; set; }
            public string Api { get; set; }
        }

        private async void btnGetApi_Click(object sender, EventArgs e)
        {
            if (!CheckResourceParameters())
            {
                MessageBox.Show("parameter invalid.");
                return;
            }
            var apiClient = new HttpClient();
            apiClient.SetBearerToken(resourceView.Token);
            var response =await apiClient.GetAsync(resourceView.Api);
            if (!response.IsSuccessStatusCode)
            {
                this.txtRescourceList.Text = response.StatusCode.ToString();
            }
            else
            {
                this.txtRescourceList.Text = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
