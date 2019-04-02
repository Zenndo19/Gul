using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void информацияОФункцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfFun p = new InfFun();
            p.Show();
        }

        private void электроинструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Power p = new Power();
            p.Show();
        }

        private void ручныеИнструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hand p = new Hand();
            p.Show();
        }

        private void информацияОТалицахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfTable p = new InfTable();
            p.Show();
        }

        private void списокПроцедурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfProc p = new InfProc();
            p.Show();
        }

        private void наименованияИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tool p = new Tool();
            p.Show();
        }
    }
}
