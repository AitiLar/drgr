using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        PostirkaEntities1 db = new PostirkaEntities1();
        public Form1()
        {
            InitializeComponent();
            table1.DataSource = db.Лист1_.ToList();
            table1.Columns[3].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Visible = true;
        }
    }
}
