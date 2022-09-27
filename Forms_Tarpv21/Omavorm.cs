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
        Label fail1 = new Label
        {
            Text = " ",
            Location = new System.Drawing.Point(150, 120),
            Size = new System.Drawing.Size(150, 30),
            BackColor = System.Drawing.Color.White,
        };
        public Omavorm() { }
        public Omavorm(string Pealkiri)
        {
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = String.Format("Kuulame esimese muusikat"),
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            nupp.Click += Nupp_Click;
            Button nupp1 = new Button
            {
                Text = String.Format("Kuulame teise muusikat"),
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp1.Click += Nupp_Click1;

            Button nupp2 = new Button
            {
                Text = String.Format("Kuulame kolmas muusikat"),
                Location = new System.Drawing.Point(250, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp2.Click += Nupp_Click2;


            this.Controls.Add(nupp);
            this.Controls.Add(nupp1);
            this.Controls.Add(nupp2);
            this.Controls.Add(fail1);
        }




        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender=(Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus==DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\Drillhoven.wav")) 
                {
                    muusika.Play();
                    fail1.Text = String.Format("Drillhoven - Fur elise drill remix(1)");
                    MessageBox.Show("Mängib muusika - Drillhoven - Fur elise drill remix(1)");
                   
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }

        private void Nupp_Click1(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\Drillhoven1.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Mängib muusika - Drillhoven - Fur elise drill remix(2)");
                    fail1.Text = String.Format("Drillhoven - Fur elise drill remix(2)");
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }

        private void Nupp_Click2(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Sa oled kindel et taha muusika kuulata?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                using (var muusika = new SoundPlayer(@"..\..\Drillhoven2.wav"))
                {
                    muusika.Play();
                    MessageBox.Show("Mängib muusika - Drillhoven - Fur elise drill remix(3)");
                    fail1.Text = String.Format("Drillhoven - Fur elise drill remix(3)");
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }

        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Omavorm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Omavorm";
            this.Load += new System.EventHandler(this.Omavorm_Load);
            this.ResumeLayout(false);

        }

        private void Omavorm_Load(object sender, EventArgs e)
        {

        }
    }
}
