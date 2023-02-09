using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“aTT2000DataSet.CHECKINOUT”中。您可以根据需要移动或移除它。
            this.cHECKINOUTTableAdapter.Fill(this.aTT2000DataSet.CHECKINOUT);
            // TODO: 这行代码将数据加载到表“aTT2000DataSet.CHECKINOUT”中。您可以根据需要移动或移除它。
            this.cHECKINOUTTableAdapter.Fill(this.aTT2000DataSet.CHECKINOUT);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.FillBy(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.FillBy1(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 查询祝老师打卡记录ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.查询祝老师打卡记录(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 查询我的打卡记录ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.查询我的打卡记录(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.查询我的打卡记录(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 查询陈老师的打卡记录ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.查询陈老师的打卡记录(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHECKINOUTTableAdapter.查询陈老师的打卡记录(this.aTT2000DataSet.CHECKINOUT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
