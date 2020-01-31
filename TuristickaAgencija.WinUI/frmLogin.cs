using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.WinUI.Zaposlenici;

namespace TuristickaAgencija.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("VrstaPutovanja");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.KorisnickoIme = txtUsername.Text;
                APIService.Lozinka = txtPassword.Text;
                var item=await _service.Get<dynamic>(null);
                   
                    frmIndex frm = new frmIndex();
                    frm.Show();
               
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Niste autentificirani!", "Authentikacija", MessageBoxButtons.OK);
                Application.Restart();
            }

        }

  
    }
}
