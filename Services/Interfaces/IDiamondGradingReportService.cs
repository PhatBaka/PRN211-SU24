using BusinessObjects;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDiamondGradingReportService
    {
        public Task<IList<DiamondGradingReport>> GetDiamondGradingReports();
        public Task<bool> CreateDiamondGradingReport(DiamondGradingReport diamondGradingReport);
        public Task<bool> UpdateDiamondGradingReport(DiamondGradingReport diamondGradingReport);
        public Task<bool> DeleteDiamondGradingReport(DiamondGradingReport diamondGradingReport);
        public Task<DiamondGradingReport> GetDiamondGradingReport(int id);
    }
}
