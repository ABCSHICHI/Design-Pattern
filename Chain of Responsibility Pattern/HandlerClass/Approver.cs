using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerClass
{
    //审批人，handler
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }

        public string Name { get; set; }

        protected Approver(string name)
        {
            Name = name;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
