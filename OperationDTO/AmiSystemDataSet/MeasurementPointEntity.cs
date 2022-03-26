
namespace OperationDTO.AmiSystemDataSet
{
    public class MeasurementPointEntity
    {
        public long MeasurementPointMeterId { get; set; }
      
        public long MeterId { get; set; }
        public long MeterCode { get; set; }
        public long CustomerId { get; set; }
        public long CustomerCode { get; set; }
        public string CustomerAddress { get; set; }
        public long DcuId { get; set; }
        public long DcuCode { get; set; }
        public long MeasurementPointId { get; set; }
        public string MeasurementPointCode { get; set; } 
        public string MeasurementPointName { get; set; }
        public string MeasurementPointAddress { get; set; }      
        public string MeasurementPointGroupId { get; set; }
        public string MeterTypeName { get; set; }
        public string MeasurementPointType { get; set; }
    }
}
