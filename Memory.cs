using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageManage
{
    class Memory
    {
        public double size { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int free = 0;
        public List<Block> Blocks=new List<Block>();
        public Memory(int size,string name)
        {
            this.size = size;
            this.name = name;
            count =( size / 4096);
            if ((size % 4096) != 0)
                count++;
            free = count-2;
            for(int i = 0; i < count; i++)
            {
                Block temp = new Block(i);
                Blocks.Add(temp);
            }
        }
    }
}
