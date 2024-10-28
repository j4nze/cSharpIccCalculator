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
        public static bool isListEmpty = true;
        public HistoryForm()
        {
            InitializeComponent();
            histHandler = new HistoryHandler();
            histHandler.AddEntry("There's no history yet.");
            buttonClearHistory.Visible = false;
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
            histHandler.ClearHistory(); // clear the list
            histHandler.AddEntry("There's no history yet.");
            buttonClearHistory.Visible = false;
        }
    }
}
