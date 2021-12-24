using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BirdWatcher
{

    /// <summary>
    /// This form class is used to display all of the
    /// current birds in a data grid view control.
    /// </summary>
    public partial class Form2 : Form
    {

        /// <summary>
        /// The constructor accepts the bird data
        /// as an argument; this list is set as
        /// the datasource for the datagridview control
        /// </summary>
        /// <param name="bd"></param>
        public Form2(List<BirdData> bd)
        {
            InitializeComponent();
            dataGridView1.DataSource = bd;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            //dataGridView1.Columns[0].C
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].SortMode = DataGridViewColumnSortMode.Automatic;


            // this is a guid to hide it
            // dataGridView1.Columns[0].Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sUrl = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            //ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);

            Process.Start("msedge.exe", sUrl);
        }
    }
}