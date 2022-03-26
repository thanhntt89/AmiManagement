
using System;
using System.Collections.Generic;
namespace AmiOperationLib
{
    [Serializable]
    public class DataField
    {
        public string TagId { get; set; }

        public string FieldCode { get; set; }

        public string Name { get; set; }

        public int Length { get; set; }

        public string Data { get; set; }

        public decimal? Value { get; set; }

        public decimal? Scale { get; set; }

        //MeterType
        public string Type { get; set; }

        public List<string> ValueList { get; set; }

        public List<DataField> ValueFullList { get; set; }

        /// <summary>
        /// List event use in dcu sao viet
        /// </summary>
        public List<DataField> EventList = new List<DataField>();

        public decimal? Scale1 { get; set; }

    }
}
