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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serik_yerassyl_dbDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.serik_yerassyl_dbDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serik_yerassyl_dbDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.serik_yerassyl_dbDataSet.Товары);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); //Переход между формами
            newForm.Show();
            this.Hide();
        }
    }
}
