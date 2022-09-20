using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Tarpv21
{
    public partial class MinuOmaVorm : Form
    {
        TreeView puu;
        Button nupp;
        Label silt;
        CheckBox nruut1, nruut2;
        RadioButton rnupp1, rnupp2, rnupp3, rnupp4;
        PictureBox pilt;
        ProgressBar riba;
        Timer aeg;


        public MinuOmaVorm()
        {
            Height = 600;
            Width = 900;
            Text = "Minu oma vorm koos elementidega";
            //BackColor = Color.Black;
            puu = new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new Point(0, 0);
            TreeNode oksad = new TreeNode("Elemendid");
            oksad.Nodes.Add(new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Silt-Label"));
            oksad.Nodes.Add(new TreeNode("Dialoog aken-MessageBox"));
            oksad.Nodes.Add(new TreeNode("Märkeruut-Checkbox"));
            oksad.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            oksad.Nodes.Add(new TreeNode("Edemisriba-ProgressBar"));





            puu.AfterSelect += Puu_AfterSelect;

            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);

        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {

            silt = new Label
            {
                Text = "Minu esimene vorm",
                Size = new Size(200, 50),
                Location = new Point(100, 0)

            };

            nruut1 = new CheckBox
            {
                Checked = false,
                Text = "Üks",
                Location = new Point(silt.Left + silt.Width, 0),
                Width = 100,
                Height = 25
            };
            nruut2 = new CheckBox
            {
                Checked = false,
                Text = "Kaks",
                Location = new Point(silt.Left + silt.Width, nruut1.Height),
                Width = 100,
                Height = 25

            };

            if (e.Node.Text == "Nupp-Button")
            {
                nupp = new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location = new Point(200, 100);

                nupp.Click += Nupp_Click;
                this.Controls.Add(nupp);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                silt = new Label
                {
                    Text = "Minu esimene vorm",
                    Size = new Size(200, 50),
                    Location = new Point(100, 0)

                };
                this.Controls.Add(silt);
                silt.MouseEnter += Silt_MouseEnter;
                silt.MouseLeave += Silt_MouseLeave;


            }
            else if (e.Node.Text == "Dialoog aken-MessageBox")
            {
                MessageBox.Show("Aken", "Kõike lihtsam aken");
                var vastus = MessageBox.Show("Kas paneme aken kinni?", "Valik", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (vastus == DialogResult.No)
                {
                    MessageBox.Show("Saada 500 euro!");
                    this.Close();


                }

            }
            else if (e.Node.Text == "Märkeruut-Checkbox")
            {
                nruut1 = new CheckBox
                {
                    Checked = false,
                    Text = "Üks",
                    Location = new Point(silt.Left + silt.Width, 0),
                    Width = 100,
                    Height = 25
                };
                nruut2 = new CheckBox
                {
                    Checked = false,
                    Text = "Kaks",
                    Location = new Point(silt.Left + silt.Width, nruut1.Height),
                    Width=100,
                    Height = 25
                   
                };
                this.Controls.Add(nruut1);
                this.Controls.Add(nruut2);

                nruut1.CheckedChanged += new EventHandler(nruut1_2_Changed);
                nruut2.CheckedChanged += new EventHandler(nruut1_2_Changed);

            }
            else if (e.Node.Text=="Radionupp-Radiobutton")
            {


                rnupp1 = new RadioButton
                {
                    Text="Paremale",
                    Width = 112,
                    Location=new Point(nruut2.Left+nruut2.Width, nruut1.Height+nruut2.Height)
                };
                rnupp2 = new RadioButton
                {
                    Text = "Vasakule",
                    Width = 112,
                    Location = new Point(nruut2.Left + nruut2.Width+rnupp1.Width, nruut1.Height + nruut2.Height)
                };
                rnupp3 = new RadioButton
                {
                    Text = "Ülesse",
                    Width = 112,
                    Location = new Point(nruut2.Left + nruut2.Width+rnupp1.Width + rnupp2.Width, nruut1.Height + nruut2.Height)
                };
                rnupp4 = new RadioButton
                {
                    Text = "Alla",
                    Width = 112,
                    Location = new Point(nruut2.Left + nruut2.Width + rnupp1.Width + rnupp2.Width + rnupp3.Width, nruut1.Height + nruut2.Height)
                };
                pilt = new PictureBox
                {
                    Image = new Bitmap("Hõiva.png"),
                    Location = new Point(300,450),
                    Size= new Size(100,100),
                    SizeMode=PictureBoxSizeMode.Zoom

                };
                this.Controls.Add(rnupp1);
                this.Controls.Add(rnupp2);
                this.Controls.Add(rnupp3);
                this.Controls.Add(rnupp4);
                this.Controls.Add(pilt);


                rnupp1.CheckedChanged += new EventHandler(rnupp1_2_3_4);
                rnupp2.CheckedChanged += new EventHandler(rnupp1_2_3_4);
                rnupp3.CheckedChanged += new EventHandler(rnupp1_2_3_4);
                rnupp4.CheckedChanged += new EventHandler(rnupp1_2_3_4);




            }
            else if (e.Node.Text == "Edemisriba-ProgressBar")
            {
                riba = new ProgressBar
                {
                    Width = 400,
                    Height = 30,
                    Location = new Point(350, 500),
                    Value = 1,
                    Minimum = 0,
                    Maximum = 100,
                    Step = 1,
                    //Dock = DockStyle.Bottom
                };

                

            };
            aeg = new Timer();
            aeg.Enabled = true;
            aeg.Tick += Aeg_Tick;
            this.Controls.Add(riba);

        }

        private void Aeg_Tick(object sender, EventArgs e)
        {
            riba.PerformStep();
        }

        int x = 350;
        int y = 400;

        private void rnupp1_2_3_4(object sender, EventArgs e)
        {

            if (rnupp1.Checked)
            {
                x += 30;
                pilt.Location = new Point(x, y);
                rnupp1.Checked = false;
            }
            else if (rnupp2.Checked)
            {
                x -= 30;
                pilt.Location = new Point(x, y);
                rnupp2.Checked = false;
            }
            else if (rnupp3.Checked)
            {
                y += 30;
                pilt.Location = new Point(x, y);
                rnupp3.Checked = false;
            }
            else if (rnupp4.Checked)
            {
                y -= 30;
                pilt.Location = new Point(x, y);
                rnupp4.Checked = false;
            }
        }

        private void nruut1_2_Changed(object sender, EventArgs e)
        {
            if (nruut1.Checked==true && nruut2.Checked==true)
            {
                MessageBox.Show("Esimene ja Teine == true", "Aken");
            }
            else if (nruut1.Checked == true && nruut2.Checked == false)
            {
                MessageBox.Show("Esimene == true, Teine == false", "Aken");
            }
            else if (nruut1.Checked == false && nruut2.Checked == true)
            {
                MessageBox.Show("Esimene == false, Teine == true", "Aken");
            }
            else if (nruut1.Checked == false && nruut2.Checked == false)
            {
                MessageBox.Show("Esimene == false, Teine == false", "Aken");
            }
        }

        private void Silt_MouseLeave(object sender, EventArgs e)
        {
            silt.ForeColor = Color.Black;
            silt.BackColor= Color.Transparent;
        }

        private void Silt_MouseEnter(object sender, EventArgs e)
        {
            silt.ForeColor = Color.White;
            silt.BackColor = Color.Black;
        }

        Random random = new Random();

        private void Nupp_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red = random.Next(100,255);
            green = random.Next(100, 255);
            blue = random.Next(100, 255);    
            this.BackColor = Color.FromArgb(red, green,blue);
        }
    }
}
