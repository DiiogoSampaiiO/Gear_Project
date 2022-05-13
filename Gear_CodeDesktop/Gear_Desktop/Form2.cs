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
        AdicionarUsuário();
    }

    private async void AdicionarUsuário()

    {
        var URI = From2URL;
        Users users = new Users();
        users.Use_email = txt_Email.Text;
        users.Usu_password = txt_Senha.Text;

        using (var client = new HttpClient())
        {
            var serializedusers = JsonConvert.SerializeObject(users);
            var content = new StringContent(serializedusers, Encoding.UTF8,"application/json");
            var response = await client.PostAsync(URI,content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuário Cadastrado : " + response.StatusCode);
            }
            else
            {
                MessageBox.Show("Usuario não existe : " + response.StatusCode);
            }
        }

    } 
}
