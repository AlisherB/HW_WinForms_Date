using System;
using System.Windows.Forms;

namespace Task
{
    public partial class FormDayOfWeek : Form
    {
        public FormDayOfWeek()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            try
            {
                dateTime = DateTime.Parse(textBoxEnter.Text);
                textBoxRes.Text = dateTime.ToString("dddd");
            }
            catch (Exception)
            {
                MessageBox.Show("Дата введена неверно (дд.мм.гггг)", "Invalid date entered");
                textBoxEnter.Clear();
                textBoxRes.Clear();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear();
        }
    }
}
