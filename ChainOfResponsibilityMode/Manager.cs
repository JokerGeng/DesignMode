using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityMode
{
    public class Manager : Approver
    {
        public Manager(string name, Approver nextApprover)
            : base(name, nextApprover)
        { }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, request.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover?.ProcessRequest(request);
            }
        }
    }
}
