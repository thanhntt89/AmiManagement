using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.SystemHistoriesDataSetTableAdapters;
using System;

namespace OperationDTO
{
    public class SystemHistoriesEntity
    {
        public string UserName { get; set; }
        public string FunctionName { get; set; }
        public string Action { get; set; }
        public string Notes { get; set; }

    }

    public class SystemHistories
    {
        SystemHistoriesDataSet.SystemHistoriesDataTable systemHistoriesDataTable = new SystemHistoriesDataSet.SystemHistoriesDataTable();
        SystemHistoriesTableAdapter systemHistoriesTableAdapter = new SystemHistoriesTableAdapter();

        public void InsertHistories(SystemHistoriesEntity systemInfo)
        {
            var newRow = this.systemHistoriesDataTable.NewSystemHistoriesRow();

            newRow.Action = systemInfo.Action;
            newRow.CreatedDate = DateTime.Now;
            newRow.FunctionName = systemInfo.FunctionName;
            newRow.Notes = systemInfo.Notes;
            newRow.UserName = systemInfo.UserName;
            this.systemHistoriesDataTable.AddSystemHistoriesRow(newRow);
            this.systemHistoriesTableAdapter.Update(this.systemHistoriesDataTable);
        }
    }


}
