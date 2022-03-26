
using AmiOperationManagement.Main;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiSystemDataSet;
using System.Collections.Generic;
using System.Linq;

namespace AmiOperationManagement
{
    public static class UserSession
    {
        public static string UserName { get; set; }

        public static SystemFunctionCollection UserFunctionList = new SystemFunctionCollection();

        public static string CurrentFunction { get; set; }
        public static string Notes { get; set; }
        public static string Action { get; set; }

        /// <summary>
        /// Danh sách gateway kết nối và trạng thái kết nối
        /// </summary>
        public static GatewayCollection GatewayList = new GatewayCollection();

        /// <summary>
        /// Thông số cấu hình hệ thống
        /// </summary>
        public static SystemConfigEntity SystemConfig = new SystemConfigEntity();

        public static SystemSubTopicCollection SystemSubTopic = new SystemSubTopicCollection();

        public static MeasurementPointGroupDataSet.MeasurementPointGroupDataTable MeasurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();

        public static StationDataSet.StationDataTable StationDataTable = new StationDataSet.StationDataTable();
    }

    public class GatewayCollection
    {
        private List<GatewayEntity> GetewayList;

        public GatewayCollection()
        {
            this.GetewayList = new List<GatewayEntity>();
        }

        public void Add(GatewayEntity gateway)
        {
            this.GetewayList.Add(gateway);
        }

        public void Clear()
        {
            this.GetewayList.Clear();
        }

        public bool GetewayConnectionStatus(string gatewayIp)
        {
            var query = this.GetewayList.Where(r => r.GetWayIP.Equals(gatewayIp));
            if (query.Count() > 0)
                return query.First().IsGatewayConnected;
            return false;
        }

        public void UpdateGatewayStatus(string gatewayIp, bool isConnected)
        {
            var query = this.GetewayList.Where(r => r.GetWayIP.Equals(gatewayIp));
            if (query.Count() > 0)
                query.First().IsGatewayConnected = isConnected;
        }
    }

    public class GatewayEntity
    {
        public string GetWayIP { get; set; }
        public bool IsGatewayConnected { get; set; }
    }

    public class SystemSubTopicCollection
    {
        private List<SubTopicEntity> SubscribeTopicList;

        public SystemSubTopicCollection()
        {
            this.SubscribeTopicList = new List<SubTopicEntity>();
        }

        public void Add(SubTopicEntity subTopic)
        {
            this.SubscribeTopicList.Add(subTopic);
        }

        public SubTopicEntity GetItem(string meterType, string messateType)
        {
            var query = this.SubscribeTopicList.Where(r => r.MeterType.Equals(meterType) && r.Topic.Contains(messateType));
            if (query.Count() > 0)
                return query.First();
            else
                return null;
        }
    }

    public class SubTopicEntity
    {
        public string MeterType { get; set; }
        public string Topic { get; set; }
    }
}
