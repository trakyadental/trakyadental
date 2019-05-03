using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental
{
    public partial class HastaIslemEkran : Form
    {

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;
        public HastaIslemEkran()
        {
            InitializeComponent();
            var index = new HastaGoruntuleEkle();
            index.BringToFront();
            
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X -lastLocation.X;
                mouseY = MousePosition.Y - lastLocation.Y;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        private void pbHastaEkle_Click(object sender, EventArgs e)
        {
            
            
            hastaEkle1.BringToFront();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
