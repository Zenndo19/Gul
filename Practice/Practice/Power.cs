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
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tool_storageDataSet1.power_tool". При необходимости она может быть перемещена или удалена.
            this.power_toolTableAdapter.Fill(this.tool_storageDataSet1.power_tool);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM power_tool WHERE ID LIKE '%"+tbmp.Text+"'", con);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            //заполняем datagridview - (поле данных...где выводится результат поиска)
            dgv.DataSource = dt;

            this.power_toolTableAdapter.Fill(this.tool_storageDataSet1.power_tool);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}