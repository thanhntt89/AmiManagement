using System.Collections.Generic;
using System.Linq;

namespace OperationDTO.AmiOperationDataSet
{
    public class FixGroupCollection
    {
        public int Count = 0;

        public List<FixGroupEntity> FixGroupList = new List<FixGroupEntity>();

        public void Add(FixGroupEntity fixGroup)
        {
            this.FixGroupList.Add(fixGroup);
            this.Count = this.FixGroupList.Count;
        }

        public FixGroupEntity GetItemByFixStepId(int fixGroupId)
        {
            var query = this.FixGroupList.Where(r => r.FixGroupId == fixGroupId);
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public FixGroupEntity GetItemByFixGroupId(int fixGroupId)
        {
            var query = this.FixGroupList.Where(r => r.FixGroupId == fixGroupId);
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public void Clear()
        {
            this.FixGroupList.Clear();
            this.Count = this.FixGroupList.Count;
        }
    }

    public class FixGroupEntity
    {
        public int FixGroupId { get; set; }
        public string FixGroupName { get; set; }
    }
}
