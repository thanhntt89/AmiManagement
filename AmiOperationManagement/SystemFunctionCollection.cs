using System.Collections.Generic;
using System.Linq;

namespace AmiOperationManagement
{
    public class SystemFunctionEntity
    {
        public string FunctionId { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public bool IsActive { get; set; }
    }

    public class SystemFunctionCollection
    {
        public List<SystemFunctionEntity> SystemFunctionList = new List<SystemFunctionEntity>();
       
        public bool CheckExist(string functionCode)
        {
            var exist = this.SystemFunctionList.Where(r => r.FunctionCode.Equals(functionCode));
            if (exist.Count() > 0)
                return exist.First().IsActive;
            else
                return false;
        }

        public void UpdateActiveFunctions(string functionCode)
        {
            var exist = this.SystemFunctionList.Where(r => r.FunctionCode.Equals(functionCode));
            if (exist.Count() > 0)
                exist.First().IsActive = true;
            else
                exist.First().IsActive = false;
        }

        public string GetFunctionName(string functionCode)
        {
            var exist = this.SystemFunctionList.Where(r => r.FunctionCode.Equals(functionCode));
            if (exist.Count() > 0)
                return exist.First().FunctionName;
            else
                return string.Empty;
        }

    }
}
