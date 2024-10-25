using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccCalculator
{
    class HistoryHandler
    {
        private List<string> historyEntries;

        public HistoryHandler()
        {
            historyEntries = new List<string>();
        }

        // add entry
        public void AddEntry(string entry)
        {
            historyEntries.Insert(0, entry);
        }

        // retrieve entries
        public List<string> GetHistory()
        {
            return historyEntries;
        }
    }
}
