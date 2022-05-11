using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Gear_Desktop.Models;


namespace Gear_Desktop;

public partial class Form2 : Form
{
    String From2URL;
    public Form2(String URL, string email)
    {
        InitializeComponent();
        txt_Email.Text = email;
        From2URL = URL;
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
        PostUsersByEmail();
    }

    private async void PostUsersByEmail()
    {
        using (var client = new HttpClient())
        {
            var URI = From2URL + txt_Email.Text;
            Users users = new Users();
            users.Use_email = txt_Email.Text;
            users.Usu_password = txt_Senha.Text;

            HttpResponseMessage response = await client.GetAsync(URI);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuario já existe : " + response.StatusCode);                
            }
            else
            {
                MessageBox.Show("Usuario não existe : " + response.StatusCode);

            }
        }
    }

    }
