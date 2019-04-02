using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice
{
    public partial class Hand : Form
    {
        [System.ComponentModel.Browsable(false)]

        public Hand()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tool_storageDataSet.hand_tool". При необходимости она может быть перемещена или удалена.
            this.hand_toolTableAdapter.Fill(this.tool_storageDataSet.hand_tool);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM hand_tool WHERE ID LIKE '%" + tbmp.Text + "'", con);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            //заполняем datagridview - (поле данных...где выводится результат поиска)
            dgv.DataSource = dt;
            this.hand_toolTableAdapter.Fill(this.tool_storageDataSet.hand_tool);
        }
    }
}
