using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageManage
{
    class Block
    {
        public int index { get; set; }
        public bool isUsed { get; set; }
        public string prId { get; set; }
        public Block(int index)
        {
            this.index = index;
            isUsed = false;
            prId = "000";
        }
        public void UseBlock(string prId)
        {
            this.prId = prId;
            isUsed = true;
        }
        public void ClearBlock()
        {
            this.prId = "000";
            isUsed = false;
        }
    }
}
