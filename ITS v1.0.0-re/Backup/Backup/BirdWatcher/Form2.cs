using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            // this is a guid to hide it
            dataGridView1.Columns[0].Visible = false;
        }

    }
}