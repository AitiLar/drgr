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
    public partial class Form3 : Form
    {
        PostirkaEntities1 db = new PostirkaEntities1();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = db.Лист1_Staff.FirstOrDefault(c => c.Логин == textBox1.Text.Trim() && c.Пароль == textBox2.Text.Trim());
            if (a != null)
            {
                MessageBox.Show("Добрый день " + a.Имя);
                this.Close();
                Form1 form = new Form1();
                form.Visible = true;
            }
            else {
                MessageBox.Show("Неверно введен логин или пароль");
            }
        }
    }
}
