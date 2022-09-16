using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agario_Fake
{
    public partial class Form1 : Form
    {
        List<PictureBox> Massa = new List<PictureBox>();
        List<PictureBox> BolasDivididas = new List<PictureBox>();
        Random rnd = new Random();

        int x, y;
        int playerSpeed = 8;
        int spawnTime = 20;

        Color[] newColor = {Color.Red, Color.Green, Color.Blue, Color.Gold, Color.Turquoise };

        bool goUp, goDown, goLeft, goRight, spaceConfirm, shiftConfirm;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Space))
            {
                spaceConfirm = true;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void SplitPicturebox()
        {
            pictureBox1.Width = pictureBox1.Width / 2;
            pictureBox1.Height = pictureBox1.Height / 2;
            PictureBox picbox = new PictureBox();
            picbox.Width = pictureBox1.Width;
            picbox.Height = pictureBox1.Height;
            picbox.BackColor = pictureBox1.BackColor;

            BolasDivididas.Add(picbox);
            picbox.Location = new Point((pictureBox1.Location.X + pictureBox1.Width) - pictureBox1.Width / 8, (pictureBox1.Location.Y + pictureBox1.Height) - pictureBox1.Height / 8);
            BolasDivididas.Add(picbox);
            this.Controls.Add(picbox);
        }
        private void MakePictureBox()
        {
            PictureBox pictureboxaleatoria = new PictureBox();
            pictureboxaleatoria.Height = 30;
            pictureboxaleatoria.Width = 30;
            pictureboxaleatoria.BackColor = newColor[rnd.Next(0, newColor.Length)];

            x = rnd.Next(10, this.ClientSize.Width - pictureboxaleatoria.Width);
            y = rnd.Next(10, this.ClientSize.Height - pictureboxaleatoria.Height);

            pictureboxaleatoria.Location = new Point(x, y);

            Massa.Add(pictureboxaleatoria);
            this.Controls.Add(pictureboxaleatoria);
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 0;
            if (goLeft)
            {
                pictureBox1.Left -= playerSpeed;    
                foreach(PictureBox bolas in BolasDivididas)
                {
                   
                }
            }
            if (goRight)
            {
                pictureBox1.Left += playerSpeed;
            }
            if (goUp)
            {
                pictureBox1.Top -= playerSpeed;
            }
            if (goDown)
            {
                pictureBox1.Top += playerSpeed;
            }

                
            if(pictureBox1.Width == 15)
            {
                label1.Text = "Massa: " + pictureBox1.Width / 15;
            }
            else
            {
                label1.Text = "Massa: " + ((pictureBox1.Width - 15) / 2).ToString();
            }
            
            

            spawnTime -= 1;

            

            if (spawnTime < 1)
            {
                MakePictureBox(); 
                spawnTime = 20;
            }
            foreach (PictureBox massa in Massa.ToList())
            {
                if (pictureBox1.Bounds.IntersectsWith(massa.Bounds))
                {
                    pictureBox1.Width += 20;
                    pictureBox1.Height += 20;
                    Massa.Remove(massa);
                    this.Controls.Remove(massa);
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up  || e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Shift)
            {
                shiftConfirm = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if(e.KeyCode == Keys.Shift)
            {
                shiftConfirm = false;
            }
        }
    }
}
