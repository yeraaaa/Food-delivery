using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serikyerassylinfo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serik_yerassyl_dbDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.serik_yerassyl_dbDataSet.Клиенты);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = "Имя LIKE'%" + textBox1.Text + "%'"; //Фильтрация имени 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked)
            {
                клиентыBindingSource.Sort = "Имя   ASC"; //Порядок имен по возрастанию
            }

            else if (radioButton1.Checked && radioButton4.Checked)
            {
                клиентыBindingSource.Sort = "Имя   DESC"; //Порядок имен по убыванию
            }

            else if (radioButton2.Checked && radioButton3.Checked)
            {
                клиентыBindingSource.Sort = "Возраст   ASC"; //Порядок возраста по возрастанию
            }

            else if (radioButton2.Checked && radioButton4.Checked)
            {
                клиентыBindingSource.Sort = "Возраст   DESC"; //Порядок возраста по убыванию
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter.Update(serik_yerassyl_dbDataSet.Клиенты); //Сохранение
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(); //Переход между формами
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Sort = null; //Очистка
        }
    }
}
