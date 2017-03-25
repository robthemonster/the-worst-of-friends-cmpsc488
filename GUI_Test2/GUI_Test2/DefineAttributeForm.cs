using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test2
{
    public partial class DefineAttributeForm : Form
    {
        public List<String> name;
        public List<int> scope;
        public List<int> value;
        public DefineAttributeForm()
        {
            InitializeComponent();

        }

        private void DefineAttributeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
