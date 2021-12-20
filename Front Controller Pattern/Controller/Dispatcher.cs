using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_Controller_Pattern
{
    /// <summary>
    /// 调度器/分配器
    /// </summary>
    class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if (request.Equals("STUDENT"))
            {
                studentView.Show();
            }
            else
            {
                homeView.Show();
            }
        }
    }
}
