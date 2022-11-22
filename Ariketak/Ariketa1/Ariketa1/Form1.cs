namespace Ariketa1
{
    public partial class Form1 : Form
    {
        Esaldia esaldia = new Esaldia();
        public Form1()
        {
            InitializeComponent();
        }
        private bool Balidatu(Button btnEsaldi1, Button btnEsaldi2)
        {
            if (txtEsaldia.Text != "")
            {
                btnEsaldi1.Enabled = false;
                btnEsaldi2.Enabled = true;
                esaldia.Zatia = txtEsaldia.Text;
                esaldia.Batu();
                txtEsaldia.Text = "";
                txtEsaldia.Focus();
                return true;
            } else
            {
                return false;
            }
        }
        private void btnEsaldi1_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = true;
            Hasieratu();

        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = true;
            Hasieratu();

        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = true;
            Hasieratu();

        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = true;
            Hasieratu();

        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = true;
            Hasieratu();

        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            btnLotu.Enabled = false;
            btnEsaldi1.Enabled = true;
            MessageBox.Show("UwU");
            Hasieratu();

        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
            
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hasieratu()
        {
            txtEsaldia.Text = "";
            txtEsaldia.Focus();
        }
    }
}