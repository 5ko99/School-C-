using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FitnessDiary
{
   

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-bg");
        }

        public  void formLoad()
        {
            Form formtoload = new frmAddActivity();
            formtoload.Show();
            GlobalClass.GlobalVariable.date = calendar.SelectionEnd.ToShortDateString();
            formtoload.Close();
            formtoload = new frmAddActivity();
            formtoload.Show();
            GlobalClass.GlobalVariable.date = calendar.SelectionEnd.ToShortDateString();
        }

        public void cmdAdd_Click(object sender, EventArgs e)
        {
            formLoad();
        }
    }
}
