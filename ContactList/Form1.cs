using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của AddContactForm
            AddContactForm addContactForm = new AddContactForm();

            // Hiển thị AddContactForm
            addContactForm.Show();

            // Hoặc nếu bạn muốn Form1 bị ẩn đi cho đến khi AddContactForm đóng lại:
            // addContactForm.ShowDialog(); 
        }
    }
}
