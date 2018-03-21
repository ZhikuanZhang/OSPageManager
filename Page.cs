using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageManage
{
    class Page
    {
        public int index { get; set; }
        public bool isUsed { get; set; }
        public string prId { get; set; }
        public Page(int index)
        {
            this.index = index;
            isUsed = false;
            prId = "0000";
        }
        public void UsePage(string prId)
        {
            isUsed = true;
            this.prId = prId;
        }
        public void ClearPage()
        {
            isUsed = false;
            this.prId = "0000";
        }
    }
}
