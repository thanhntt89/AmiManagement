

using System.Collections.Generic;
using System.Windows.Forms;

namespace AmiOperationLib
{
    public class Constant
    {
        /// <summary>
        /// Define for dcu type decode thread
        /// </summary>
        public enum AmiType
        {
            Meter1Phase = 1,
            Meter3Phase = 2
        };

        public const string UpdateMeasurementPointText = "Sửa điểm";
        public const string CreatedMeasurementPointText = "Điểm mới";

        public const string StopSendingText = "Dừng gửi";
        public const string StopingSendingText = "Đang dừng";
        public const string ProccessingText = "Đã xử lý được {0}/{1} yêu cầu.";
        public const string StopProccessingText = "Tiến trình đang dừng xử lý";

        public const int IsFixed = 1;
        public const int IsNotFixed = 0;
        public const int Selected_ALL = -1;

        public const bool IsDeleted = true;
        public const bool IsUsed = true;

        public const string CLIENT_CONNECTION = "AmiSystemConnectionString";
        public const string ADMIN_CONNECTION = "AmiSystemOperationConnectionString";
        public const string SUPPER_USER = "administrator";
        public const string ROOT_FUNCTION = "1";
        public const string SELECT_ALL_TEXT = "Tất cả";
        public const string SERVER_PATH_TEXT = "Đường dẫn trên máy chủ";
        public const string SERVER_SAOVIET_TEXT = "DANH SÁCH SERVER";
        public const string FUNCTION_GROUP_TEXT = "DANH SÁCH NHÓM QUYỀN";
        public const string SERVER_TOPIC_TEXT = "DANH SÁCH BẢN TIN NHẬN";
        public const string ERROR_LIST_HEADER = "DANH SÁCH LỖI - MODEM THIẾU BẢN TIN";
        public const string MENU_MODEM_COMMANDER_TEXT = "Điều khiển modem";
        public const string MENU_MODEM_COMMANDER_CODE = "MENU_MODEM_COMMANDER_CODE";
        public const string USER_PASSWORD_DEFAULT = "123456";
        public const string USER_ACTIVE_STATUS = "Hoạt động";
        public const string USER_DEACTIVE_STATUS = "Dừng hoạt động";

        public const string SERVER_TYPE_FTP = "FTP";
        public const string SERVER_FOLDER_PATH = "Firmware";
        public const int DCU_TOPIC_INDEX = 4;

        public const int MENU_DEPLOY_INDEX = 0;
        public const int MENU_OPERATION_INDEX = 1;
        public const int MENU_ERROR_INDEX = 2;
        public const int MENU_REPORT_INDEX = 3;

        public const string MENU_MODEM_OPERATION_TEXT = "Điều khiển modem";
        public const string MeterTypeAllText = "Tất cả các loại công tơ";
        public const string SubScribeText = "Nhận dữ liệu";
        public const string UnSubscribeText = "Dừng nhận dữ liệu";
        public const string REQUEST_FIRMWARE = "REQUEST_FIRMWARE";
        public const string REQUEST_OPERATION = "REQUEST_OPERATION";
        public const string REQUEST_INTAN = "REQUEST_INTAN";
        public const string REQUEST_HISTORIES = "REQUEST_HISTORIES";
        public const string REQUEST_LOADPROFILE = "REQUEST_LOADPROFILE";
        public const string REQUEST_DCU_SERVER_CONFIG = "REQUEST_DCU_SERVER_CONFIG";
        public const string REQUEST_RESET = "REQUEST_RESET";
        public const string RECEIVE_ERASE_FLASH = "RECEIVE_ERASE_FLASH";
        public const string REQUEST_ERASE_FLASH = "REQUEST_ERASE_FLASH";
        public const string REQUEST_CONFIG_OPERATION_TIME = "REQUEST_CONFIG_OPERATION_TIME";


        public const string SERVER_CONNECT_STATUS_TEXT = "Kết nối";
        public const string SERVER_DISCONNECT_STATUS_TEXT = "Mất kết nối";
        public const int CONNECT_STATUS = 1;

        public const string PublicMessage = "PUB";
        public const string SubscribeMessage = "SUB";
        public const string TestMessage = "TES";
        public const string Gateway = "GATEWAY";
        public const string TestTopic = "TEST1";

        public const string NUMBER_OF_DCU_REQUEST_OPERATION = "NUMBER_OF_DCU_REQUEST_OPERATION";
        public const string NUMBER_OF_DATE_REQUEST_LOADPROFILE = "NUMBER_OF_DATE_REQUEST_LOADPROFILE";
        public const string NUMBER_OF_DATE_REQUEST_OPERATION = "NUMBER_OF_DATE_REQUEST_OPERATION";
        public const string NUMBER_OF_TIME_REQUEST_OPERATION = "NUMBER_OF_TIME_REQUEST_OPERATION";
        public const string NUMER_OF_TIME_CONFIG_DCU_READ_OPERATION = "NUMER_OF_TIME_CONFIG_DCU_READ_OPERATION";
        public const string NUMER_OF_TIME_CONFIG_SEND_MESSAGE = "NUMER_OF_TIME_CONFIG_SEND_MESSAGE";

        public const string VALUE_COLUMN = "Value";

        public const string OBIS_SERVER1 = "01";
        public const string OBIS_PORT1 = "02";
        public const string OBIS_USER1 = "03";
        public const string OBIS_PASS1 = "04";

        public const string OBIS_LOADPROFILE_DAY = "01";


        public const string OBIS_SERVER2 = "05";
        public const string OBIS_PORT2 = "06";
        public const string OBIS_USER2 = "07";
        public const string OBIS_PASS2 = "08";

        public const string OBIS_FIRMWARE_PATH = "01";
        public const string OBIS_FIRMWARE_FILE_NAME = "02";
        public const string OBIS_FIRMWARE_FILE_SIZE = "03";

        public const string START_EA = "EA";
        public const string END_EB = "EB";

        public const string ACTION_RESET = "Khởi động lại modem";
        public const string ACTION_UPDATE_FIRMWARE = "Cập nhật phần mềm";
        public const string ACTION_ERASE_FLASH = "Xoá bộ nhớ modem";

        // Message Alert config
        public const string TopicAlertDcuConfig = "AMI/{0}/cAlar";
        // Topic response first message from DCU 
        public const string TopicResponseForDCUofFirstMessage = "AMI/{0}/MePDV";
        public const string PayloadResponseToDcu = "Thank You!!!";
        // Topic request DCU config server
        public const string TopicConfigServerMQTT = "AMI/{0}/cPort";
        // Topic request DCU Operation
        public const string TopicConfigOperation = "AMI/{0}/Opera";
        // Topic request DCU Billing
        public const string TopicConfigBilling = "AMI/{0}/Histo";

        public const string SendAll = "SendAll";
        public const string UpdateFirmware = "UpdateFirmware";
        public const string UpdateAddress = "UpdateAddress";
        public static string ServerConfigFile = Application.StartupPath + "\\ServerConfig.xml";
        public static string SystemConfig = Application.StartupPath + "\\SystemConfig.xml";

        // DCU config request from web
        public const string RequestSystemConfig = "MePDV";

        //Constant update DcuId for MpId
        public const int Active = 1;
        public const int RecoveryMp = 0;
        public const int UnregisterMp = 3;
        public const string ActiveText = "Hoạt động";
        public const string RecoveryMpText = "Thanh lý";
        public const string UnregisterMpText = "Chưa đăng ký";
        public const string DeletedText = "Đã xoá";
        public const string DcuConnectedText = "Kết nối";
        public const string DcuDisconnectedText = "Mất kết nối";
        public const string NotDefined = "Chưa xác định";
        public const int DcuConnected = 1;
        public const string Processing = "Đang xử lý...";
        public const string Processed = "Đã xử lý";
        public const bool NotDeleted = false;
        public const bool Deleted = true;

        //Cosntant Update MeasurementPoint
        public const string HeaderEdit = "SỬA THÔNG TIN";
        public const string HeaderCreateNew = "TẠO MỚI";
        public const int ContractD1 = 2;
        public const int ContractD2 = 1;
        public const string ContractD1Text = "HD01 - Hợp đồng 1000 điểm";
        public const string ContractD2Text = "HD02 - Hợp đồng 2600 điểm";


        public const string DcuTemp = "DcuTemp";
        public const string MeterTemp = "MeterTemp";

        public const string Error = "Lỗi";

        public const string SelectText = "--Chọn--";
        //Constant Meter
        public const string Used = "Đã sử dụng";
        public const string Unused = "Chưa sử dụng";
        public const string TypeBilling0 = "Loại 0: Chốt theo chỉ số tích luỹ tới thời điểm chốt";
        public const string TypeBilling1 = "Loại 1: Chốt theo chỉ số tiêu dùng theo chu kỳ chốt";

        public const string MessageOperation = "Operation";

        public static string MessageBilling = "Billing";
        public const string ActiveStatus = "Hoạt động";

        public static string DeactiveStatus = "Không hoạt động";

        //Error
        public const string ErorText = "Lỗi";
        public const string FirmwareErrorText = "FirmwareError,";
        public const string FlashErorText = " Lỗi Flash,";
        public const string PendingErorText = " Lỗi Pendding,";
        public const string CompareByteErorText = " Lỗi so byte,";
        public const string OkText = "OK";

        public const string WarningChangeMeterText = "Thay công tơ";
        public const string WarningDcuDisconnectMeter = "Mất kết nối với công tơ";
        public const string WarningMeterDataWrongText = "Sai dữ liệu công tơ";
        public const string WarningErrorLineText = "Lỗi dây đọc công tơ";

        // Định nghĩa bản tin
        public const string WarningTopic = "WaDcu";
        public const string OperationTopic = "Opera";
        public const string LoadProfileTopic = "LoPro";
        public const string IntantanTopic = "Intan";
        public const string HistoriesTopic = "Histo";

        // TreeNodeType
        public const string NodeTypeRoot = "NodeTypeRoot";
        public const string NodeTypeOrg = "NodeTypeOrg";
        public const string NodeTypeMpGroup = "NodeTypeMpGroup";
    }
}