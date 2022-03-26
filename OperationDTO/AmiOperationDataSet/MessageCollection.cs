using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationDTO.AmiOperationDataSet
{
    public class MessageCollection
    {
        public List<MessageEntity> MessageList;

        public MessageCollection()
        {
            this.MessageList = new List<MessageEntity>();
        }

        public void Add(MessageEntity message)
        {
            this.MessageList.Add(new MessageEntity
            {
                Index = this.MessageList.Count + 1,
                ServerTime = message.ServerTime,
                ReceiveTime = message.ReceiveTime,
                Topic = message.Topic,
                Data = message.Data
            });
        }

        public MessageEntity GetMessageByMessageIndex(int index)
        {
            var query = this.MessageList.Where(r => r.Index == index);
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public MessageCollection GetMessageByTopic(string topic)
        {
            MessageCollection messageCollectionTemp = new MessageCollection();

            var query = this.MessageList.Where(r => r.Topic.Equals(topic)).OrderByDescending(r => r.ServerTime);
            if (query.Count() > 0)
                messageCollectionTemp.MessageList = query.ToList();
            return messageCollectionTemp;
        }

        public void Clear()
        {
            this.MessageList.Clear();
        }
    }

    public class MessageEntity
    {
        public int Index { get; set; }

        public string Topic { get; set; }

        public string ReceiveTime { get; set; }
        public byte[] Data { get; set; }
        public DateTime ServerTime { get; set; }
    }
}
