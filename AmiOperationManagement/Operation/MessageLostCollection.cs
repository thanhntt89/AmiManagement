using System;
using System.Collections.Generic;

namespace AmiOperationManagement.ErrorManagement
{
    public class MessageLostEntity
    {
        public string DcuId { get; set; }
        public DateTime TimeLost { get; set; }
    }

    public class MessageLostCollection
    {
       public List<MessageLostEntity> MessageLostList = new List<MessageLostEntity>();
       public string MessageType { get; set; }
    }

}
