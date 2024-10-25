using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    public partial class HistoryForm : UserControl
    {
        private HistoryHandler histHandler;
        public HistoryForm()
        {
            InitializeComponent();
            listBoxHistory.Items.Add("There's no history yet.");
        }
    }
}
