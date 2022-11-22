namespace Ariketa_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (rbtnKontaktua.Checked)
            {
                KontaktuaSortu();
            }
            else
            {
                if (rbtnBezeroa.Checked)
                {
                    BezeroaSortu();
                }
                else
                {
                    LangileaSortu();
                }
            }
        }
        private void KontaktuaSortu()
        {
            try
            {
                Kontaktua kontaktua = new Kontaktua();
                kontaktua.Izena = txtIzena.Text;
                kontaktua.Abizena = txtAbizena.Text;
                kontaktua.Nan = txtNan.Text;
                kontaktua.Emaila = txtEmail.Text;
                MessageBox.Show(kontaktua.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BezeroaSortu()
        {
            try
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.Izena = txtIzena.Text;
                bezeroa.Abizena = txtAbizena.Text;
                bezeroa.Nan = txtNan.Text;
                bezeroa.Emaila = txtEmail.Text;
                bezeroa.Kategoria = cboxKategoria.Text;
                MessageBox.Show(bezeroa.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LangileaSortu()
        {
            try
            {
                Langilea langilea = new Langilea();
                langilea.Izena = txtIzena.Text;
                langilea.Abizena = txtAbizena.Text;
                langilea.Nan = txtNan.Text;
                langilea.Emaila = txtEmail.Text;
                langilea.Soldata = txtSoldata.Text;
                langilea.SegurtasunSoziala = txtSegurtasunSoziala.Text;

                MessageBox.Show(langilea.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}