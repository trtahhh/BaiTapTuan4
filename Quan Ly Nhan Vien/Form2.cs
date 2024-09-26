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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        public string ID { get; set; }
        public string Name {  get; set; }
        public int Salary {  get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ID = txtID.Text;
            Name = txtName.Text;
            Salary = int.Parse(txtSalary.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
