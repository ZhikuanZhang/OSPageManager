using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageManage
{
    class Progress
    {
        public string prId { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public int count { get; set; }
        public List<int> pageTable {get;set;}
        public Progress(string prId,string name,int size)
        {
            this.prId = prId;
            this.name = name;
            this.size = size;
            pageTable = new List<int>();
            count = (size / 4096);
            if ((size % 4096) != 0)
                count++;
            for (int i = 0; i < count; i++)
            {
                pageTable.Add(0);
            }
        }
    }
}
