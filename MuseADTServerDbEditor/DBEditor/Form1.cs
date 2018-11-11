using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbLoader;
namespace DBEditor
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> data;
        private Dictionary<string, string> temp;
        private List<KeyValuePair<string, string>> dataForGridView;
        private string path;
        DbLoader.DbLoader dbLoader;

        DataView dv;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable("Names");
            dv = new DataView(dt);
            namesDGV.DataSource = dv;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
           

            if (openDbDialog.ShowDialog() == DialogResult.OK)
            {
                path = openDbDialog.FileName;
                dt.Clear();
            }
            LoadData(path);
        }

        private void LoadData(string dbFilePath)
        {
            dbLoader = new DbLoader.DbLoader(dbFilePath);
            temp = dbLoader.GetData();
            dataForGridView = temp.ToList();
            InitColumns(dt);
            FillRows(dataForGridView, dt);

        }

        private void InitColumns(DataTable dt)
        {
            if (!dt.Columns.Contains("HebrewName"))
            {
                dt.Columns.Add("HebrewName");
            }
            if (!dt.Columns.Contains("EnglishName"))
            {
                dt.Columns.Add("EnglishName");
            }
            
        }

        private void FillRows(List<KeyValuePair<string, string>> names , DataTable dataTable)
        {
            foreach (KeyValuePair<string, string> row in names)
            {
                dataTable.Rows.Add(row.Key, row.Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("EnglishName LIKE '*{0}*' OR HebrewName LIKE '*{0}*'", searchBox.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString());
            }
            dbLoader.SaveData(temp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt.Clear();
            LoadData(path);
        }
    }
}
