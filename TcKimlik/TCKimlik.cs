using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace TcKimlik
{
    public partial class TCKimlik : MetroForm
    {
        readonly Kimlik _tcKimlikC = new Kimlik();
        public TCKimlik()
        {
            InitializeComponent();
        }

        private void TCKimlik_Load(object sender, EventArgs e)
        {

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(textBox1.Text, out sayi))
            {
                sayi = Convert.ToInt32(textBox1.Text);
                var rnd = new Random();
                //     int sayi = Convert.ToInt32(textBox1.Text);
                for (int n = 0; n < sayi; n++)
                {
                    string no = _tcKimlikC.RasgeleTcNo(rnd);
                    listBox1.Items.Add(no);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Lütfen kaç  adet istediğinizi girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


           
        }


        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            if (_tcKimlikC.Dogrula(listBox1.SelectedItem.ToString()))
            {
                lblSonuc.ForeColor = Color.LightGreen;

                lblSonuc.Text = @"Doğrulandı!";
            }
            else
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonuc.Text = @"Doğrulanamadı!";
            }
        }

        private void btnListeTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
