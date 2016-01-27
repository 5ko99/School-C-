using System;
using System.Windows.Forms;

namespace FitnessDiary
{
    public partial class frmAddActivity : Form
    {
        public frmAddActivity()
        {
            InitializeComponent();
            
        }

        private void frmAddActivity_Load(object sender, EventArgs e)
        {
            textBox1.Text = GlobalClass.GlobalVariable.date;
        }
    }
}
