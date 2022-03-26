using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ModemTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.SystemConfigDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.StationDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiOperationManagement.Main
{
    public partial class StartupSystem : Form
    {
        private AutoResetEvent timeOutEvent = new AutoResetEvent(false);

        public bool isLoadSusess = false;

        string subscribeTopic = string.Empty;
        // Thứ tự các đối số trong cấu trúc bản tin 
        const int modemIndex = 0;
        const int meterIndex = 1;
        const int dcuIndex = 2;

        private ModemTypeDataSet.ModemTypeDataTable modemTypeDataTable = new ModemTypeDataSet.ModemTypeDataTable();
        private ModemTypeTableAdapter modemTypeTableAdapter = new ModemTypeTableAdapter();

        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private SystemConfigEntity systemConfig = new SystemConfigEntity();
        private SystemConfigDataSet.SystemConfigDataTable systemConfigDataTable = new SystemConfigDataSet.SystemConfigDataTable();
        private SystemConfigTableAdapter systemConfigTableAdapter = new SystemConfigTableAdapter();


        private StationDataSet.StationDataTable stationDataTable = new StationDataSet.StationDataTable();
        private StationTableAdapter stationTableAdapter = new StationTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

        private BackgroundWorker bgwWaiting;

        public StartupSystem()
        {
            InitializeComponent();
        }
        
        private void LoadMeterType()
        {
            try
            {
                this.meterTypeTableAdapter.Fill(this.meterTypeDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load METER. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.isLoadSusess = false;
            }
        }

        private void LoadModemType()
        {
            try
            {
                this.modemTypeTableAdapter.FillByIsUsed(this.modemTypeDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load MODEM. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.isLoadSusess = false;
            }
        }

        private void LoadCommandLine()
        {
            try
            {
                this.commandLineTableAdapter.FillByCommandType(this.commandLineDataTable, Constant.SubscribeMessage);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "Lỗi load commandline. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại bản tin.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.isLoadSusess = false;
            }
        }

        private void LoadSystemConfig()
        {
            try
            {
                this.systemConfigTableAdapter.Fill(this.systemConfigDataTable);

                systemConfig.NumberOfModemRequestOperation = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMBER_OF_DCU_REQUEST_OPERATION).Field<string>(Constant.VALUE_COLUMN).ToString());

                systemConfig.NumberOfDateRequesOperation = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMBER_OF_DATE_REQUEST_OPERATION).Field<string>(Constant.VALUE_COLUMN).ToString());

                systemConfig.NumberOfDateRequestLoadProfile = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMBER_OF_DATE_REQUEST_LOADPROFILE).Field<string>(Constant.VALUE_COLUMN).ToString());

                systemConfig.NumberOfTimeRequestOperation = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMBER_OF_TIME_REQUEST_OPERATION).Field<string>(Constant.VALUE_COLUMN).ToString());

                systemConfig.NumerOfTimeConfigDcuReadOperation = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMER_OF_TIME_CONFIG_DCU_READ_OPERATION).Field<string>(Constant.VALUE_COLUMN).ToString());

                systemConfig.NumerOfTimeConfigSendMessage = int.Parse(this.systemConfigDataTable.FindByConfigCode(Constant.NUMER_OF_TIME_CONFIG_SEND_MESSAGE).Field<string>(Constant.VALUE_COLUMN).ToString()) * 1000;

                UserSession.SystemConfig = systemConfig;

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCDCUCONTROLLER. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tìm được dữ liệu cấu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.isLoadSusess = false;
            }
        }
        
        private void LoadMeasurementPointGroup()
        {
            try
            {
                measurementPointGroupTableAdapter.Fill(UserSession.MeasurementPointGroupDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPointGroup - Tải dữ liệu cho LoadMeasurementPointGroup không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin điện lực quản lý điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStation()
        {
            try
            {
                this.stationTableAdapter.FillByIsDeletedStatus(UserSession.StationDataTable, false);

                
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeter - Tải dữ liệu cho LoadMeter không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin trạm từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartWaiting()
        {
            if (bgwWaiting == null)
            {
                bgwWaiting = new BackgroundWorker();
                bgwWaiting.DoWork += bgwWaiting_DoWork;
                bgwWaiting.RunWorkerCompleted += bgwWaiting_RunWorkerCompleted;
            }

            bgwWaiting.RunWorkerAsync();
        }

        void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            this.LoadCommandLine();
            this.LoadModemType();
            this.LoadMeterType();
            this.LoadSystemConfig();
            this.LoadMeasurementPointGroup();
            this.LoadStation();

            this.CreatedTopic();           
        }

        void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwWaiting.Dispose();
            bgwWaiting = null;
            this.Close();
        }

        private void CreatedTopic()
        {
            var pattern = @"{(.*?)}";
            subscribeTopic = string.Empty;
            try
            {
                foreach (ModemTypeDataSet.ModemTypeRow item in modemTypeDataTable.Rows)
                {
                    foreach (MeterTypeDataSet.MeterTypeRow meterType in meterTypeDataTable.Rows)
                    {

                        foreach (CommandLineDataSet.CommandLineRow node in this.commandLineDataTable)
                        {
                            var matches = Regex.Matches(node.Topic, pattern);
                            var totalMatchCount = matches.Count;
                            object[] par = new object[totalMatchCount];

                            for (int i = 0; i < totalMatchCount; i++)
                            {
                                switch (i)
                                {
                                    case modemIndex:
                                        par[i] = item.ModemType;
                                        break;
                                    case meterIndex:
                                        par[i] = meterType.MeterCode;
                                        break;
                                    case dcuIndex:
                                        par[i] = "{0}";
                                        break;
                                    default:
                                        break;
                                }
                            }

                            UserSession.SystemSubTopic.Add(
                                new SubTopicEntity
                                {
                                    Topic = String.Format(node.Topic, par),
                                    MeterType = meterType.MeterCode
                                });

                        }
                    }
                }

                this.isLoadSusess = true;
            }
            catch
            {
                this.isLoadSusess = false;
            }
            timeOutEvent.WaitOne(5500);
        }

        private void StartupSystem_Load(object sender, EventArgs e)
        {
            
            this.StartWaiting();
        }
    }
}
