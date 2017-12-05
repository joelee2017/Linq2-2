using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Linq2
{
    
    public partial class Form1 : Form
    {                  
        
        public Form1()
        {
            InitializeComponent();
        }


        ClsProduct[] p = new ClsProduct[]
        {
            new ClsProduct{Id="a01",Name="0001",Price=1000},
            new ClsProduct{Id="a01",Name="0002",Price=800},
            new ClsProduct{Id="a01",Name="0003",Price=600},
            new ClsProduct{Id="a01",Name="0004",Price=400},
            new ClsProduct{Id="a01",Name="0005",Price=200}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = from r in p
                         where r.Name.Contains(txtSearch.Text)
                         select r;
            dataGridView1.DataSource = result.ToList();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Form1_Load(sender, e);
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var result = from r in p
                         orderby r.Price ascending
                         select r;
            dataGridView1.DataSource = result.ToList();
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var result = from r in p
                         orderby r.Price descending
                         select r;
            dataGridView1.DataSource = result.ToList();
        }
    }
}
