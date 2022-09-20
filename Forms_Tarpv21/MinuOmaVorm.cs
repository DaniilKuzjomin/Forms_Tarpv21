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


        public MinuOmaVorm()
        {
            Height = 600;
            Width = 900;
            Text = "Minu oma vorm koos elementidega";
            //BackColor = Color.Black;
            puu= new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new Point(0,0);
            TreeNode oksad = new TreeNode("Elemendid");
            oksad.Nodes.Add(new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Silt-Label"));
            oksad.Nodes.Add(new TreeNode("Dialoog aken-MessageBox"));





            puu.AfterSelect += Puu_AfterSelect;

            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);

        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp-Button")
            {
                nupp=new Button();
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
            else if (e.Node.Text== "Dialoog aken-MessageBox")
            {
                MessageBox.Show("Aken","Kõike lihtsam aken");
                var vastus = MessageBox.Show("Kas paneme aken kinni?","Valik", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vastus==DialogResult.Yes)
                {
                    this.Close();
                }
                else if (vastus==DialogResult.No)
                {
                    MessageBox.Show("Saada 500 euro!");
                    this.Close();
                }

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
