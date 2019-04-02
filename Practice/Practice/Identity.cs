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
    public partial class Identity : Form
    {
        public Identity()
        {
            InitializeComponent();
            serv.Text = Properties.Settings.Default.ConstServ;
            bd.Text = Properties.Settings.Default.Constbd;
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            if (serv.Text == "" || bd.Text == "")
            {
                MessageBox.Show("Введено пустое значение", "Ошибка!");
            }
            Main ff = new Main();
            this.Hide();
            ff.Show();
        }

        private void serv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Identity_Load(object sender, EventArgs e)
        {
            
        }
    }
}
