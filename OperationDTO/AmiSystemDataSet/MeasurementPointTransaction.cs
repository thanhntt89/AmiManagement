using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointMeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.Operation3PDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OperationDTO.AmiSystemDataSet
{
    public class MeasurementPointTransaction
    {
        public void AddMeasurementPoint(MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable, MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTable, MeasurementPointTableAdapter measurementPointTableAdapter, MeasurementPointMeterTableAdapter measurementPointMeterTableAdapter)
        {
            SqlTransaction transaction = TableAdapterUtil.GetTransaction(measurementPointTableAdapter);

            TableAdapterUtil.SetTransaction(measurementPointMeterTableAdapter, transaction);
            try
            {
                // Gọi ra xử lý đăng ký ở tâng business
                measurementPointTableAdapter.Update(measurementPointDataTable);
                measurementPointMeterTableAdapter.Update(measurementPointMeterDataTable);
                // Nếu ko có lỗi sảy ra
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                // Trả exception cho tầng trên xử lý
                throw ex;
            }
            finally
            {
                if (transaction.Connection != null)
                {
                    if (transaction.Connection.State == ConnectionState.Open)
                    {
                        transaction.Connection.Close();
                    }
                }
            }
        }

        public void ChangeMeasurementPoint(MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTableOld, MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTableOld, Operation3PDataSet.UpdateMeasurementPointMeterForOperation3PDataTable updateMeasurementPointMeterForOperation3PDataTable, MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTableCurrent, MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTableCurrent,
            MeasurementPointTableAdapter measurementPointTableAdapter,
            MeasurementPointMeterTableAdapter measurementPointMeterTableAdapter,
            Operation3PTableAdapter operation3PTableAdapter,
            UpdateMeasurementPointMeterForOperation3PTableAdapter updateMeasurementPointMeterForOperation3PTableAdapter)
        {
            SqlTransaction transaction = TableAdapterUtil.GetTransaction(measurementPointTableAdapter);
            TableAdapterUtil.SetTransaction(measurementPointMeterTableAdapter, transaction);
            TableAdapterUtil.SetTransaction(operation3PTableAdapter, transaction);
            TableAdapterUtil.SetTransaction(updateMeasurementPointMeterForOperation3PTableAdapter, transaction);
            try
            {
                // Gọi ra xử lý đăng ký ở tâng business
                // Update lại DcuId mới cho điểm cũ
                measurementPointTableAdapter.Update(measurementPointDataTableOld);

                // Update lại MeterId mới cho điểm cũ
                measurementPointMeterTableAdapter.Update(measurementPointMeterDataTableOld);

                // Update lại MeasurementPointMeterId cũ cho bản tin operation3p của điểm mới
                if (updateMeasurementPointMeterForOperation3PDataTable.Rows.Count > 0)
                    updateMeasurementPointMeterForOperation3PTableAdapter.UpdateNewMeasurementPointMeterId(updateMeasurementPointMeterForOperation3PDataTable.First().NewMeasurementPointMeterId, updateMeasurementPointMeterForOperation3PDataTable.First().MeasurementPointMeterId, updateMeasurementPointMeterForOperation3PDataTable.First().MeterId);

                // Update lại thông tin DcuId cho điểm mới
                measurementPointTableAdapter.Update(measurementPointDataTableCurrent);

                // Update lại thông tin MeterId cho điểm mới
                measurementPointMeterTableAdapter.Update(measurementPointMeterDataTableCurrent);

                // Nếu ko có lỗi sảy ra
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                // Trả exception cho tầng trên xử lý
                throw ex;
            }
            finally
            {
                if (transaction.Connection != null)
                {
                    if (transaction.Connection.State == ConnectionState.Open)
                    {
                        transaction.Connection.Close();
                    }
                }
            }
        }
    }
}
