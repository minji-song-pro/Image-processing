using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 영상처리소프트웨어
{
    public partial class Sub_Input1 : Form
    {
        public Sub_Input1()
        {
            InitializeComponent();
        }

        private void 숫자1개입력_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void numeric_double1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
