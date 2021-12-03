using HandlerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manger = new Manager("LearningHard");
            Approver Vp = new VicePresident("Tony");
            Approver Pre = new President("BossTom");

            //设置责任链
            manger.NextApprover = Vp;
            Vp.NextApprover = Pre;

            //处理请求
            manger.ProcessRequest(requestTelphone);
            manger.ProcessRequest(requestSoftware);
            manger.ProcessRequest(requestComputers);

        }
    }
}



