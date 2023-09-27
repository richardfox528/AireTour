using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.AcceptButton = btnSendPassword;
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                btnSendPassword.Enabled = false;
                MessageBox.Show("Por favor escribir una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSendPassword.Enabled = true;
            }
            else
            {
                if (txtPassword.Text == "123")
                {
                    // Ir a nuevo form
                    var dataForm = new Data();
                    dataForm.Show();
                    Hide();
                }
                else
                {
                    btnSendPassword.Enabled = false;
                    MessageBox.Show("Ingrese una contraseña correcta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSendPassword.Enabled = true;
                    txtPassword.Clear();
                }
            }
            txtPassword.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txtPassword;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Arial", 12);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Clear();
            txtPassword.Focus();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var fileName = "info.txt";
            var route = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            var read = File.ReadAllText(route);
            lblInfoIndex.Text = read;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendPassword.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
