﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityMode
{
    // ConcreteHandler，总经理
    public class President : Approver
    {
        public President(string name, Approver nextApprover)
            : base(name, nextApprover)
        { }
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000.0)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("Request需要组织一个会议讨论");
            }
        }
    }
}
