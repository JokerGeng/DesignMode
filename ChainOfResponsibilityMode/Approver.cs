using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityMode
{
    // 审批人,Handler
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }
        public string Name { get; set; }
        public Approver(string name, Approver nextApprover)
        {
            this.Name = name;
            this.NextApprover = nextApprover;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
