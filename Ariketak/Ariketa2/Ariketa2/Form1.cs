namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtZenbakia.Focus(); // ??
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            this.txtPausoa.Text = "1. Zenbakia";
            this.txtZenbakia.Text = "";
            zenbakiak.znb1 = 0;
            zenbakiak.znb2 = 0;
            zenbakiak.znb3 = 0;
            zenbakiak.znb4 = 0;

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (this.txtPausoa.Text.ToLower())
            {
                case "zenbakia 1":
            }

        }
    }
}