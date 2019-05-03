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
    public partial class MaliIslemleri : Form
    {

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;
        public MaliIslemleri()
        {
            InitializeComponent();
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

        private void pbGelirGiderIslemleri_Click(object sender, EventArgs e)
        {


            blue.Top = pbGelirGiderIslemleri.Top;
           gelirGiderRaporu1.Show();
            //gelirGiderRaporu1.Hide();
            doktorOdemeleri1.Hide();
            odemeIslemleri1.Hide();
            personelOdemeleri1.Hide();
            laboratuvarOdemeleri1.Hide();

        }

        private void pbOdemeIslemleri_Click(object sender, EventArgs e)
        {
            blue.Top = pbOdemeIslemleri.Top;
            odemeIslemleri1.Show();
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            pbDoktorOdemeleri.Visible = true;
            pbLaboratuvarOdemeleri.Visible = true;
            pbPersonelOdemeleri.Visible = true;
            gelirGiderRaporu1.Hide();
            doktorOdemeleri1.Hide();
            //odemeIslemleri1.Hide();
            personelOdemeleri1.Hide();
            laboratuvarOdemeleri1.Hide();

        }

        private void pbDoktorOdemeleri_Click(object sender, EventArgs e)
        {
            blue.Top = pbDoktorOdemeleri.Top;
            doktorOdemeleri1.Show();
            gelirGiderRaporu1.Hide();
            //doktorOdemeleri1.Hide();
            odemeIslemleri1.Hide();
            personelOdemeleri1.Hide();
            laboratuvarOdemeleri1.Hide();
        }

        private void pbLaboratuvarOdemeleri_Click(object sender, EventArgs e)
        {
            blue.Top = pbLaboratuvarOdemeleri.Top;
            laboratuvarOdemeleri1.Show();
            gelirGiderRaporu1.Hide();
            doktorOdemeleri1.Hide();
            odemeIslemleri1.Hide();
            personelOdemeleri1.Hide();
            //laboratuvarOdemeleri1.Hide();
        }

        private void pbPersonelOdemeleri_Click(object sender, EventArgs e)
        {
            blue.Top = pbPersonelOdemeleri.Top;
            personelOdemeleri1.Show();
            gelirGiderRaporu1.Hide();
            doktorOdemeleri1.Hide();
            odemeIslemleri1.Hide();
            //personelOdemeleri1.Hide();
            laboratuvarOdemeleri1.Hide();

        }

        private void MaliIslemleri_Load(object sender, EventArgs e)
        {
            
            gelirGiderRaporu1.Hide();
            doktorOdemeleri1.Hide();
            odemeIslemleri1.Hide();
            personelOdemeleri1.Hide();
            laboratuvarOdemeleri1.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
