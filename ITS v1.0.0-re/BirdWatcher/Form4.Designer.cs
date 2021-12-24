namespace ITS
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.autoriusDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.išleidimoMetaiDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.pasaulioIstorijaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.lietuvosIstorijaDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Nuoroda = new System.Windows.Forms.DataGridViewLinkColumn();
            this.šaltiniaiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet3 = new ITS.Database2DataSet3();
            this.šaltiniaiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet2 = new ITS.Database2DataSet2();
            this.šaltiniaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new ITS.Database2DataSet();
            this.šaltiniaiTableAdapter = new ITS.Database2DataSetTableAdapters.ŠaltiniaiTableAdapter();
            this.database2DataSet1 = new ITS.Database2DataSet1();
            this.šaltiniaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.šaltiniaiTableAdapter1 = new ITS.Database2DataSet1TableAdapters.ŠaltiniaiTableAdapter();
            this.šaltiniaiTableAdapter2 = new ITS.Database2DataSet2TableAdapters.ŠaltiniaiTableAdapter();
            this.šaltiniaiTableAdapter3 = new ITS.Database2DataSet3TableAdapters.ŠaltiniaiTableAdapter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoriusDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.išleidimoMetaiDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.pasaulioIstorijaDataGridViewTextBoxColumn,
            this.lietuvosIstorijaDataGridViewTextBoxColumn,
            this.Nuoroda});
            this.dataGridView2.DataSource = this.šaltiniaiBindingSource3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(1067, 437);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView2.RowTemplate.Height = 100;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(1067, 437);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // autoriusDataGridViewTextBoxColumn
            // 
            this.autoriusDataGridViewTextBoxColumn.DataPropertyName = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.FillWeight = 20F;
            this.autoriusDataGridViewTextBoxColumn.HeaderText = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.Name = "autoriusDataGridViewTextBoxColumn";
            this.autoriusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.FillWeight = 20F;
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            this.pavadinimasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // išleidimoMetaiDataGridViewTextBoxColumn
            // 
            this.išleidimoMetaiDataGridViewTextBoxColumn.DataPropertyName = "Išleidimo metai";
            this.išleidimoMetaiDataGridViewTextBoxColumn.FillWeight = 20F;
            this.išleidimoMetaiDataGridViewTextBoxColumn.HeaderText = "Išleidimo metai";
            this.išleidimoMetaiDataGridViewTextBoxColumn.Name = "išleidimoMetaiDataGridViewTextBoxColumn";
            this.išleidimoMetaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.FillWeight = 20F;
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pasaulioIstorijaDataGridViewTextBoxColumn
            // 
            this.pasaulioIstorijaDataGridViewTextBoxColumn.DataPropertyName = "Pasaulio istorija";
            this.pasaulioIstorijaDataGridViewTextBoxColumn.FillWeight = 20F;
            this.pasaulioIstorijaDataGridViewTextBoxColumn.HeaderText = "Pasaulio istorija";
            this.pasaulioIstorijaDataGridViewTextBoxColumn.Name = "pasaulioIstorijaDataGridViewTextBoxColumn";
            this.pasaulioIstorijaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pasaulioIstorijaDataGridViewTextBoxColumn.Width = 150;
            // 
            // lietuvosIstorijaDataGridViewTextBoxColumn
            // 
            this.lietuvosIstorijaDataGridViewTextBoxColumn.DataPropertyName = "Lietuvos istorija";
            this.lietuvosIstorijaDataGridViewTextBoxColumn.FillWeight = 20F;
            this.lietuvosIstorijaDataGridViewTextBoxColumn.HeaderText = "Lietuvos istorija";
            this.lietuvosIstorijaDataGridViewTextBoxColumn.Name = "lietuvosIstorijaDataGridViewTextBoxColumn";
            this.lietuvosIstorijaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lietuvosIstorijaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Nuoroda
            // 
            this.Nuoroda.DataPropertyName = "Nuoroda";
            this.Nuoroda.HeaderText = "Nuoroda";
            this.Nuoroda.Name = "Nuoroda";
            // 
            // šaltiniaiBindingSource3
            // 
            this.šaltiniaiBindingSource3.DataMember = "Šaltiniai";
            this.šaltiniaiBindingSource3.DataSource = this.database2DataSet3;
            // 
            // database2DataSet3
            // 
            this.database2DataSet3.DataSetName = "Database2DataSet3";
            this.database2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // šaltiniaiBindingSource2
            // 
            this.šaltiniaiBindingSource2.DataMember = "Šaltiniai";
            this.šaltiniaiBindingSource2.DataSource = this.database2DataSet2;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // šaltiniaiBindingSource
            // 
            this.šaltiniaiBindingSource.DataMember = "Šaltiniai";
            this.šaltiniaiBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // šaltiniaiTableAdapter
            // 
            this.šaltiniaiTableAdapter.ClearBeforeFill = true;
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // šaltiniaiBindingSource1
            // 
            this.šaltiniaiBindingSource1.DataMember = "Šaltiniai";
            this.šaltiniaiBindingSource1.DataSource = this.database2DataSet1;
            // 
            // šaltiniaiTableAdapter1
            // 
            this.šaltiniaiTableAdapter1.ClearBeforeFill = true;
            // 
            // šaltiniaiTableAdapter2
            // 
            this.šaltiniaiTableAdapter2.ClearBeforeFill = true;
            // 
            // šaltiniaiTableAdapter3
            // 
            this.šaltiniaiTableAdapter3.ClearBeforeFill = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(442, 53);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 437);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Katalogas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.šaltiniaiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource šaltiniaiBindingSource;
        private Database2DataSetTableAdapters.ŠaltiniaiTableAdapter šaltiniaiTableAdapter;
        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource šaltiniaiBindingSource1;
        private Database2DataSet1TableAdapters.ŠaltiniaiTableAdapter šaltiniaiTableAdapter1;
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource šaltiniaiBindingSource2;
        private Database2DataSet2TableAdapters.ŠaltiniaiTableAdapter šaltiniaiTableAdapter2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn autoriusDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn išleidimoMetaiDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn pasaulioIstorijaDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn lietuvosIstorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Nuoroda;
        private Database2DataSet3 database2DataSet3;
        private System.Windows.Forms.BindingSource šaltiniaiBindingSource3;
        private Database2DataSet3TableAdapters.ŠaltiniaiTableAdapter šaltiniaiTableAdapter3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}