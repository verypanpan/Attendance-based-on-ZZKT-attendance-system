namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aTT2000DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTT2000DataSet = new WindowsFormsApp2.ATT2000DataSet();
            this.cHECKINOUTTableAdapter = new WindowsFormsApp2.ATT2000DataSetTableAdapters.CHECKINOUTTableAdapter();
            this.查询祝老师打卡记录ToolStrip = new System.Windows.Forms.ToolStrip();
            this.查询祝老师打卡记录ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERIFYCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENSORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userExtFmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTT2000DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTT2000DataSet)).BeginInit();
            this.查询祝老师打卡记录ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.cHECKTIMEDataGridViewTextBoxColumn,
            this.cHECKTYPEDataGridViewTextBoxColumn,
            this.vERIFYCODEDataGridViewTextBoxColumn,
            this.sENSORIDDataGridViewTextBoxColumn,
            this.memoinfoDataGridViewTextBoxColumn,
            this.workCodeDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.userExtFmtDataGridViewTextBoxColumn,
            this.maskflagDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTT2000DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // aTT2000DataSetBindingSource
            // 
            this.aTT2000DataSetBindingSource.DataMember = "CHECKINOUT";
            this.aTT2000DataSetBindingSource.DataSource = this.aTT2000DataSet;
            // 
            // aTT2000DataSet
            // 
            this.aTT2000DataSet.DataSetName = "ATT2000DataSet";
            this.aTT2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHECKINOUTTableAdapter
            // 
            this.cHECKINOUTTableAdapter.ClearBeforeFill = true;
            // 
            // 查询祝老师打卡记录ToolStrip
            // 
            this.查询祝老师打卡记录ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.查询祝老师打卡记录ToolStripButton,
            this.toolStripButton1});
            this.查询祝老师打卡记录ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.查询祝老师打卡记录ToolStrip.Name = "查询祝老师打卡记录ToolStrip";
            this.查询祝老师打卡记录ToolStrip.Size = new System.Drawing.Size(366, 25);
            this.查询祝老师打卡记录ToolStrip.TabIndex = 2;
            this.查询祝老师打卡记录ToolStrip.Text = "查询祝老师打卡记录ToolStrip";
            // 
            // 查询祝老师打卡记录ToolStripButton
            // 
            this.查询祝老师打卡记录ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.查询祝老师打卡记录ToolStripButton.Name = "查询祝老师打卡记录ToolStripButton";
            this.查询祝老师打卡记录ToolStripButton.Size = new System.Drawing.Size(120, 22);
            this.查询祝老师打卡记录ToolStripButton.Text = "查询祝老师打卡记录";
            this.查询祝老师打卡记录ToolStripButton.Click += new System.EventHandler(this.查询祝老师打卡记录ToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel1.Text = "查询我的打卡记录";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(132, 22);
            this.toolStripButton1.Text = "查询陈老师的打卡记录";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Frozen = true;
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "用户ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.Width = 83;
            // 
            // cHECKTIMEDataGridViewTextBoxColumn
            // 
            this.cHECKTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cHECKTIMEDataGridViewTextBoxColumn.DataPropertyName = "CHECKTIME";
            this.cHECKTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.cHECKTIMEDataGridViewTextBoxColumn.HeaderText = "打卡时间";
            this.cHECKTIMEDataGridViewTextBoxColumn.Name = "cHECKTIMEDataGridViewTextBoxColumn";
            this.cHECKTIMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // cHECKTYPEDataGridViewTextBoxColumn
            // 
            this.cHECKTYPEDataGridViewTextBoxColumn.DataPropertyName = "CHECKTYPE";
            this.cHECKTYPEDataGridViewTextBoxColumn.HeaderText = "打卡类型";
            this.cHECKTYPEDataGridViewTextBoxColumn.Name = "cHECKTYPEDataGridViewTextBoxColumn";
            // 
            // vERIFYCODEDataGridViewTextBoxColumn
            // 
            this.vERIFYCODEDataGridViewTextBoxColumn.DataPropertyName = "VERIFYCODE";
            this.vERIFYCODEDataGridViewTextBoxColumn.HeaderText = "VERIFYCODE";
            this.vERIFYCODEDataGridViewTextBoxColumn.Name = "vERIFYCODEDataGridViewTextBoxColumn";
            this.vERIFYCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sENSORIDDataGridViewTextBoxColumn
            // 
            this.sENSORIDDataGridViewTextBoxColumn.DataPropertyName = "SENSORID";
            this.sENSORIDDataGridViewTextBoxColumn.HeaderText = "SENSORID";
            this.sENSORIDDataGridViewTextBoxColumn.Name = "sENSORIDDataGridViewTextBoxColumn";
            this.sENSORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // memoinfoDataGridViewTextBoxColumn
            // 
            this.memoinfoDataGridViewTextBoxColumn.DataPropertyName = "Memoinfo";
            this.memoinfoDataGridViewTextBoxColumn.HeaderText = "Memoinfo";
            this.memoinfoDataGridViewTextBoxColumn.Name = "memoinfoDataGridViewTextBoxColumn";
            this.memoinfoDataGridViewTextBoxColumn.Visible = false;
            // 
            // workCodeDataGridViewTextBoxColumn
            // 
            this.workCodeDataGridViewTextBoxColumn.DataPropertyName = "WorkCode";
            this.workCodeDataGridViewTextBoxColumn.HeaderText = "WorkCode";
            this.workCodeDataGridViewTextBoxColumn.Name = "workCodeDataGridViewTextBoxColumn";
            this.workCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.Visible = false;
            // 
            // userExtFmtDataGridViewTextBoxColumn
            // 
            this.userExtFmtDataGridViewTextBoxColumn.DataPropertyName = "UserExtFmt";
            this.userExtFmtDataGridViewTextBoxColumn.HeaderText = "UserExtFmt";
            this.userExtFmtDataGridViewTextBoxColumn.Name = "userExtFmtDataGridViewTextBoxColumn";
            this.userExtFmtDataGridViewTextBoxColumn.Visible = false;
            // 
            // maskflagDataGridViewTextBoxColumn
            // 
            this.maskflagDataGridViewTextBoxColumn.DataPropertyName = "mask_flag";
            this.maskflagDataGridViewTextBoxColumn.HeaderText = "mask_flag";
            this.maskflagDataGridViewTextBoxColumn.Name = "maskflagDataGridViewTextBoxColumn";
            this.maskflagDataGridViewTextBoxColumn.Visible = false;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 511);
            this.Controls.Add(this.查询祝老师打卡记录ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "我的考勤记录查询器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTT2000DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTT2000DataSet)).EndInit();
            this.查询祝老师打卡记录ToolStrip.ResumeLayout(false);
            this.查询祝老师打卡记录ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ATT2000DataSet aTT2000DataSet;
        private System.Windows.Forms.BindingSource aTT2000DataSetBindingSource;
        private ATT2000DataSetTableAdapters.CHECKINOUTTableAdapter cHECKINOUTTableAdapter;
        private System.Windows.Forms.ToolStrip 查询祝老师打卡记录ToolStrip;
        private System.Windows.Forms.ToolStripButton 查询祝老师打卡记录ToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERIFYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENSORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userExtFmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
    }
}

