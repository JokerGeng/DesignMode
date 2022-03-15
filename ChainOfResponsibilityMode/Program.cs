using System;

namespace ChainOfResponsibilityMode
{
    class Program
    {
        static void Main(string[] args)
        {
            //请求
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            //批准人
            Approver president = new President("President", null);
            Approver vicePresident = new VicePresident("VicePresident", president);
            Approver manager = new Manager("Manager", vicePresident);

            ////下个责任人
            //manager.NextApprover = vicePresident;
            //vicePresident.NextApprover = president;

            //处理请求
            manager.ProcessRequest(requestTelphone);
            manager.ProcessRequest(requestSoftware);
            manager.ProcessRequest(requestComputers);
            Console.Read();
        }
    }
}
