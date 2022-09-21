using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Tarpv21
{
    public class Omavorm : Form
    {
        public Omavorm() { }
        public Omavorm(string Pealkiri, string Nupp, string Fail)
        {
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(50,50),
                Size = new System.Drawing.Size(100,50),
                BackColor = System.Drawing.Color.White,

            };

            nupp.Click += Nupp_Click;
            Label failnimi = new Label
            {
                Text= Fail,
                Location = new System.Drawing.Point(150, 150),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            this.Controls.Add(nupp);
            this.Controls.Add(failnimi);
        }

       


        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender=(Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus==DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\konfuz.wav")) 
                {
                    muusika.Play();
                    MessageBox.Show("Mängib muusika - Konfuz - Кайф ты поймала.");
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }
    }
}
