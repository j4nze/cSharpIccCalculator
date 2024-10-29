using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class HistoryHandler
    {
        private List<string> historyEntries;

        public HistoryHandler()
        {
            historyEntries = new List<string>();
        }

        public void AddEntry(string entry)
        {
            historyEntries.Insert(0, entry);
        }

        public List<string> GetHistory()
        {
            return historyEntries;
        }

        public void ClearHistory()
        {
            historyEntries.Clear();
        }
    }
}
