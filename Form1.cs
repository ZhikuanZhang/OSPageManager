using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageManage
{
    public partial class MainForm : Form
    {
        Dictionary<string, Progress> progresses;
        Memory mem { get; set; }
        public MainForm()
        {
            progresses = new Dictionary<string, Progress>();
            InitializeComponent();
        }
        public void ST(string text)
        {
            DisplayBox.AppendText(text + "\n");
        }
        private void NewMemBtn_Click(object sender, EventArgs e)
        {
            if(MemSizeTB.Text==""|| MemNameTB.Text=="")
            {
                ST("输入不能为空！");
                ST("---------------------------------------");
                return;
            }
            mem = new Memory(int.Parse(MemSizeTB.Text), MemNameTB.Text);
            progresses = new Dictionary<string, Progress>();
            ST("成功创建内存区域："+mem.name);
            ST("空间大小：" + mem.size+" Byte");
            ST("物理块数量：" + mem.count);
            ST("---------------------------------------");
            DisplayGB.Text = mem.name;
            
        }

        private void NewPrBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            if (NewPrSizeTB.Text == ""|| NewPrIDTB.Text==""|| NewPrNameTB.Text=="")
            {
                ST("输入不能为空！");
                ST("---------------------------------------");
                return;
            }

            Progress p = new Progress(NewPrIDTB.Text, NewPrNameTB.Text, int.Parse(NewPrSizeTB.Text));
      
            if (CreateTablePage(p) == 0)
            {
                ST("进程创建失败");
                ST("---------------------------------------");
                return;
            }

            progresses.Add(p.prId, p);
            NewPrIDTB.Clear();
            NewPrNameTB.Clear();
            NewPrSizeTB.Clear();
            ST("成功创建进程：" + p.prId);
            ST("进程编号：" + p.prId);
            ST("进程名称：" + p.name);
            ST("所占空间：" + p.size+" Byte");
            ST("页数：" + p.count);
            ST("剩余块数：" + mem.free);
            ST("---------------------------------------");
        }
        private int CreateTablePage(Progress p)
        {
            if (mem.free<p.count)
                return 0;
            if (mem.free < mem.count / 2)
                ST("存储空间已使用过半！！！");
            Random ra = new Random();
            for (int i = 0; i < p.count; i++)
            {
                int d = ra.Next(1,mem.count);//内存第一块和最后一块不使用
                while (mem.Blocks[d].isUsed)
                {
                    if (d < mem.count-2)
                        d = d + 1;
                    else
                        d = 1;
                }
                p.pageTable[i] = d;
                mem.Blocks[d].UseBlock(p.prId);
                mem.free--;
            }
            return 1;
        }

        private void DelPrBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            if (DelPrTB.Text == "")
            {
                ST("输入不能为空！");
                ST("---------------------------------------");
                return;
            }
            int c = 0;
            string temp = DelPrTB.Text;
            if(!progresses.ContainsKey(temp))
            {
                ST("释放进程失败，进程" + temp + "不存在！");
                ST("---------------------------------------");
                return;
            }
            foreach (int m in progresses[temp].pageTable)
            {
                mem.Blocks[m].ClearBlock();
                mem.free++;
                c++;
            }
            progresses.Remove(temp);
            DelPrTB.Clear();
            ST("成功删除进程：" + temp);
            ST("共释放"+ c +"个空闲块.");
            ST("剩余块数：" + mem.free);
            ST("---------------------------------------");

        }

        private void SearchPrBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            if (SearchPrTB.Text == "")
            {
                ST("输入不能为空！");
                ST("---------------------------------------");
                return;
            }
            string temp = SearchPrTB.Text;
            if(!progresses.ContainsKey(temp))
            {
                ST("查询失败，进程" + temp + "不存在！");
                ST("---------------------------------------");
                return;
            }
            Progress p = progresses[temp];
            SearchPrTB.Clear();
            ST("查询成功！");
            ST("进程编号：" + p.prId);
            ST("进程名称：" + p.name);
            ST("所占空间：" + p.size+" Byte");
            ST("页数：" + p.count);
            ST("页表详情：页号    块号");
            int i = 0;
            foreach(int m in p.pageTable)
            {
                if(i<10)
                    ST("                " + i+"        "+m);
                else
                    ST("               " + i + "        " + m);
                i++;
            }
            ST("---------------------------------------");
        }

        private void SearchMemBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            if (SearchMemTB.Text == "")
            {
                ST("输入不能为空！");
                ST("---------------------------------------");
                return;
            }
            int temp = int.Parse(SearchMemTB.Text);
            if (temp>=mem.count)
            {
                ST("查询失败，物理块" + temp + "不存在！");
                ST("---------------------------------------");
                return;
            }
            Block b = mem.Blocks[temp];
            SearchMemTB.Clear();
            ST("查询成功！");
            ST("物理块编号：" + temp);
            if (b.prId == "000")
                ST("该物理块未被使用");
            else
                ST("所属进程：" + b.prId);
            ST("空间大小：" + "4096 Byte");
            ST("---------------------------------------");
        }

        private void ShowPrBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            int prcount = progresses.Count;
            if (prcount == 0)
            {
                ST("当前内存中无进程.");
                ST("---------------------------------------");
                return;
            }
            ST("当前内存共有" + prcount + "个进程");
            ST("剩余块数：" + mem.free);
            foreach (KeyValuePair<string,Progress> pp in progresses)
            {
                Progress p = pp.Value;
                ST("");
                ST("进程编号：" + p.prId);
                ST("进程名称：" + p.name);
                ST("所占空间：" + p.size+" Byte");
                ST("页数：" + p.count);
                
            }
            ST("---------------------------------------");


        }

        private void ShowMemBtn_Click(object sender, EventArgs e)
        {
            if (mem == null)
            {
                ST("尚未创建内存！");
                ST("---------------------------------------");
                return;
            }
            ST("区域名称：" + mem.name);
            ST("空间大小：" + mem.size + " Byte");
            ST("物理块数量：" + mem.count);
            ST("物理块大小：4096 Byte");
            ST("空闲块数量：" + mem.free);
            ST("空闲区域大小：" + mem.free * 4096 + " Byte");
            ST("---------------------------------------");
        }

        private void InfoSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "pm files(*.pm)|*.pm|All files(*.*)|*.*";
           
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(mem.name);
                sw.WriteLine(mem.size);
                foreach (KeyValuePair<string, Progress> pp in progresses)
                {
                    Progress p = pp.Value;
                    string temp = "";
                    temp = temp + p.prId + '#' + p.name + '#' + p.size;
                    sw.WriteLine(temp);
                }
                sw.Flush();
                sw.Close();
                ST("保存内存状态成功");
                ST("---------------------------------------");
            }
        }

        private void InfoLoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                //ST(File.ReadAllText(path));
                StreamReader sr = new StreamReader(path, Encoding.Default);
                String line;
                int i = 0;
                string name = ""; int size = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i == 0)
                        name = line;
                    else if (i == 1)
                    {
                        size = int.Parse(line);
                        mem = new Memory(size, name);
                        progresses = new Dictionary<string, Progress>();
                    }
                    else if (i > 1)
                    {
                        string[] temp = line.Split('#');
                        Progress p = new Progress(temp[0], temp[1], int.Parse(temp[2]));
                        if (CreateTablePage(p) == 0)
                        {
                            mem = new Memory(size, name);
                            progresses = new Dictionary<string, Progress>();
                            ST("载入内存状态失败！");
                            ST("---------------------------------------");
                            return;
                        }
                        progresses.Add(p.prId, p);
                    }
                    i++;
                }
                i = i - 2;
                ST("载入内存状态成功！共载入" + i + "个进程");
                ST("---------------------------------------");
                DisplayGB.Text = mem.name;
                sr.Close();
            }          
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
        }
    }
}
