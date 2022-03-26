using AmiOperationManagement.CustomeUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmiOperationManagement.Main
{

    public class FunctionEntity
    {
        public int Index { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public UserControlBase DisplayForm { get; set; }
    }

    public class FunctionCollection
    {
        public List<FunctionEntity> FunctionList = new List<FunctionEntity>();

        public void AddFunction(string functionCode, string functionName)
        {
            this.FunctionList.Add(new FunctionEntity { Index = this.FunctionList.Count, FunctionCode = functionCode, FunctionName = functionName });
        }

        public void AddFunction(string functionCode, string functionName, UserControlBase usercontrol)
        {
            this.FunctionList.Add(new FunctionEntity { Index = this.FunctionList.Count, FunctionCode = functionCode, FunctionName = functionName, DisplayForm = usercontrol });
        }

        public void RemoveItem(string functionCode)
        {
            var exist = this.GetFunctionInfoByFunctionCode(functionCode);
            if (exist != null)
            {
                int indexReomved = this.FunctionList.IndexOf(exist);
                exist.DisplayForm.RemoveCOMOpen();
                exist.DisplayForm = null;
                this.FunctionList.RemoveAt(indexReomved);
            }
        }

        public FunctionEntity GetFunctionInfoByFunctionCode(string functionCode)
        {
            if (this.FunctionList.Count == 0)
                return null;

            var exist = this.FunctionList.Where(r => r.FunctionCode.Equals(functionCode));
            if (exist.Count() > 0)
                return exist.First();
            else
                return null;
        }

        public FunctionEntity GetFunctionInfoByFunctionName(string functionName)
        {
            if (this.FunctionList.Count == 0)
                return null;

            var exist = this.FunctionList.Where(r => r.FunctionName.Equals(functionName));
            if (exist.Count() > 0)
                return exist.First();
            else
                return null;
        }

        public void RemoveItemByName(string functionName)
        {
            var exist = this.GetFunctionInfoByFunctionName(functionName);
            if (exist != null)
            {
                int indexReomved = this.FunctionList.IndexOf(exist);
                exist.DisplayForm.RemoveCOMOpen();
                exist.DisplayForm = null;
                this.FunctionList.RemoveAt(indexReomved);
            }
        }
    }
}
