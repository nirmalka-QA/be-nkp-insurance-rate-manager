using System;
using System.Collections.Generic;

namespace NKPInsuranceRateManager
{
    public class RateUpdateHistory
    {
        private List<string> updateHistory = new List<string>();

        public void RecordRateUpdate(string updateDetails)
        {
            // Logic to record rate update details
            updateHistory.Add(updateDetails);
        }

        public List<string> GetUpdateHistory()
        {
            // Logic to retrieve rate update history
            return updateHistory;
        }
    }
}