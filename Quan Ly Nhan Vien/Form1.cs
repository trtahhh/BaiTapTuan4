using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Vien
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();  
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(frm.ID, frm.Name, frm.Salary);
            }
        }
        
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm2 frm = new frm2();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells[0].Value = frm.ID;
                    selectedRow.Cells[1].Value = frm.Name;
                    selectedRow.Cells[2].Value = frm.Salary;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
    }
}
