using System.Collections.Generic;
using System.Linq;

namespace OperationDTO.AmiOperationDataSet
{
    public class FixStepErrorEntity
    {
        public int FixStepId { get; set; }
        public int StepIndex { get; set; }
        public int FixGroupId { get; set; }
        public string FixGroupName { get; set; }
        public string FixStepName { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorName { get; set; }
    }

    public class FixStepErrorCollection
    {
        public int Count = 0;

        public List<FixStepErrorEntity> FixStepErrorList = new List<FixStepErrorEntity>();

        public void Add(FixStepErrorEntity fixStepError)
        {           
            this.FixStepErrorList.Add(fixStepError);
            this.Count = this.FixStepErrorList.Count;
        }

        public FixStepErrorEntity GetItemByFixStepId(int fixStepId)
        {
            var query = this.FixStepErrorList.Where(r => r.FixStepId == fixStepId);
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public FixStepErrorEntity GetItemByErrorCode(string errorCode)
        {
            var query = this.FixStepErrorList.Where(r => r.ErrorCode.Equals(errorCode));
            if (query.Count() > 0)
                return query.First();
            return null;
        }

        public void Clear()
        {
            this.FixStepErrorList.Clear();
            this.Count = this.FixStepErrorList.Count;
        }
    }
}
