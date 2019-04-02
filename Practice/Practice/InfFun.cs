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
    public partial class InfFun : Form
    {
        public InfFun()
        {
            InitializeComponent();
        }

        private void InfFun_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tool_storageDataSet4.pro". При необходимости она может быть перемещена или удалена.
            this.proTableAdapter.Fill(this.tool_storageDataSet4.pro);

        }
    }
}
