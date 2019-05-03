using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrakyaDental.HastaIslemleri
{
    public partial class HastaEkle : UserControl
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
