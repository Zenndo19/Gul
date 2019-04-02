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
    public partial class Tool : Form
    {
        public Tool()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tool_storageDataSet2.tool_name". При необходимости она может быть перемещена или удалена.
            this.tool_nameTableAdapter.Fill(this.tool_storageDataSet2.tool_name);

        }
    }
}
