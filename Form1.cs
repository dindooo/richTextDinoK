using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richBoxDinoK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tekst.rtf");
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {           
             richTextBox1.SaveFile(@"C:Tekst.rtf");
             MessageBox.Show("Tekst je spremljen");          
        }

        private void btnBriši_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
