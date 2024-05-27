using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impls
{
    public class DiamondGradingReportService : IDiamondGradingReportService
    {
        private readonly IGenericRepository<DiamondGradingReport> _diamondGradingReportRepository;

        public DiamondGradingReportService(IGenericRepository<DiamondGradingReport> diamondGradingReportRepository)
        {
            _diamondGradingReportRepository = diamondGradingReportRepository;
        }

        public async Task<IList<DiamondGradingReport>> GetDiamondGradingReports()
        {
            try
            {
                var diamondGradingReport = await _diamondGradingReportRepository.GetAllAsync();
                return diamondGradingReport.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving diamond grading report: {ex.Message}", ex);
            }
        }

        public async Task<bool> CreateDiamondGradingReport(DiamondGradingReport diamondGradingReport)
        {
            try
            {
                return await _diamondGradingReportRepository.InsertAsync(diamondGradingReport);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating diamon grading report: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateDiamondGradingReport(DiamondGradingReport diamondGradingReport)
        {
            try
            {
                return await _diamondGradingReportRepository.UpdateByIdAsync(diamondGradingReport, diamondGradingReport.ReportId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating diamond grading report: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteDiamondGradingReport(DiamondGradingReport diamondGradingReport)
        {
            try
            {
                return await _diamondGradingReportRepository.DeleteAsync(diamondGradingReport);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting diamond grading report: {ex.Message}", ex);
            }
        }

        public async Task<DiamondGradingReport> GetDiamondGradingReport(int id)
        {
            try
            {
                return await _diamondGradingReportRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving diamond grading report by ID: {ex.Message}", ex);
            }
        }
    }
}
