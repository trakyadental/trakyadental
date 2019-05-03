﻿using System;
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
    public partial class KlinikIslemleri : Form
    {

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        Point lastLocation;
        public KlinikIslemleri()
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

        private void pbPersonelBilgileri_Click(object sender, EventArgs e)
        {
            blue.Top = pbPersonelBilgileri.Top;
            personelBilgileri1.Show();
            randevuDefteri1.Hide();
            smSveEmailIslemleri1.Hide();
        }

        private void pbRandevuDefteri_Click(object sender, EventArgs e)
        {
            blue.Top = pbRandevuDefteri.Top;
            randevuDefteri1.Show();
            smSveEmailIslemleri1.Hide();
            personelBilgileri1.Hide();
        }

        private void pbSMSveEmail_Click(object sender, EventArgs e)
        {
            blue.Top = pbSMSveEmail.Top;
            smSveEmailIslemleri1.Show();
            personelBilgileri1.Hide();
            randevuDefteri1.Hide();
        }

        private void KlinikIslemleri_Load(object sender, EventArgs e)
        {
            blue.Top = pbPersonelBilgileri.Top;
            personelBilgileri1.Hide();
            randevuDefteri1.Hide();
            smSveEmailIslemleri1.Hide();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
