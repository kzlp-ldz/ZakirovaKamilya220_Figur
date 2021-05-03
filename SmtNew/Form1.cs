using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtNew
{
    public partial class Form1 : Form
    {
        int radisu = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            graphics.FillEllipse(Brushes.Black, e.X, e.Y, radisu * 2, radisu * 2);
            graphics.Dispose();
        }
    }
}
