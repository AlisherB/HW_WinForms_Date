using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            try
            {
                dateTime = DateTime.Parse(textBoxEnter.Text);
                textBoxRes.Text = dateTime.ToString("dddd");
            }
            catch (Exception)
            {
                MessageBox.Show("Дата введена неверно (дд.мм.гггг)", "Error");
                textBoxEnter.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear();
        }
    }
}
