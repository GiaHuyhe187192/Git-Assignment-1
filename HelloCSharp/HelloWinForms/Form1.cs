using System;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

       
            Button btnHello = new Button();
            btnHello.Text = "Xin chào";
            btnHello.Top = 30;
            btnHello.Left = 30;
            btnHello.Click += BtnHello_Click;

           
            Button btnBye = new Button();
            btnBye.Text = "Tạm biệt";
            btnBye.Top = 70;  
            btnBye.Left = 30;
            btnBye.Click += BtnBye_Click;

            this.Controls.Add(btnHello);
            this.Controls.Add(btnBye);
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào 👋");
        }

        private void BtnBye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạm biệt 👋");
        }
    }
}
