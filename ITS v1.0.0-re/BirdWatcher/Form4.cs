using BirdWatcher;
using DataGridViewAutoFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITS
{
    public partial class Form4 : Form
    {
       
        public Form4(List<BirdData> bd)
        {
            InitializeComponent();
           
            
            //BindingSource data = this.DataTable.DataSource as BindingSource;
           // DataTable.DataSource = bd;

            // dataGridView2;
           


        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sUrl = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

            //ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);

            Process.Start("msedge.exe",sUrl);
        }
       

        private void Form4_Load(object sender, EventArgs e)
        {
           /* progressBar1.Visible = true;
            progressBar1.Value = progressBar1.Step;*/

            this.šaltiniaiTableAdapter3.Fill(this.database2DataSet3.Šaltiniai);
            /* // TODO: This line of code loads data into the 'database2DataSet3.Šaltiniai' table. You can move, or remove it, as needed.
             this.šaltiniaiTableAdapter3.Fill(this.database2DataSet3.Šaltiniai);
             // TODO: This line of code loads data into the 'database2DataSet2.Šaltiniai' table. You can move, or remove it, as needed.
             this.šaltiniaiTableAdapter2.Fill(this.database2DataSet2.Šaltiniai);
             // TODO: This line of code loads data into the 'database2DataSet1.Šaltiniai' table. You can move, or remove it, as needed.
             this.šaltiniaiTableAdapter1.Fill(this.database2DataSet1.Šaltiniai);*/



        }
    }
}
