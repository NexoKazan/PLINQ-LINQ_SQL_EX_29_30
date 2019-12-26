using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void Q29()
        {
            Console.WriteLine(Environment.NewLine + "Q29" + Environment.NewLine);
            //SELECT i.point, i.date, i.inc, o.out
            //FROM income_o i
            //    LEFT JOIN outcome_o o ON i.point = o.point AND i.date = o.date
            DataBaseDataContext context = new DataBaseDataContext();

            Console.WriteLine(Environment.NewLine + "INCOME" + Environment.NewLine);

            var income_res = from i1 in context.Income_o
                from o1 in context.Outcome_o.Where(x => i1.point == x.point && i1.date == x.date).DefaultIfEmpty()
                select new {i1.point, i1.date, inc = (decimal?)i1.inc, outc = (decimal?)o1.@out};
            foreach (var t in income_res)
            {
                Console.WriteLine(t.point + "\t" + t.date + "\t" + t.inc + "\t" + t.outc);
            }

            //SELECT o.point, o.date, i.inc, o.out
            //FROM outcome_o o
            //    LEFT JOIN income_o i ON o.point = i.point AND o.date = i.date

            Console.WriteLine(Environment.NewLine + "OUTCOME" + Environment.NewLine);

            var outcome_res = from o1 in context.Outcome_o
                from i1 in context.Income_o.Where(x => o1.point == x.point && o1.date == x.date).DefaultIfEmpty()
                select new {o1.point, o1.date, inc = (decimal?)i1.inc, outc = (decimal?)o1.@out};
            foreach (var t in outcome_res)
            {
                Console.WriteLine(t.point + "\t" + t.date + "\t" + t.inc + "\t" + t.outc);
            }
            
            Console.WriteLine(Environment.NewLine + "UNION" + Environment.NewLine);

            var union_res = income_res.Union(outcome_res);

            foreach (var t in union_res)
            {
                Console.WriteLine(t.point + "\t" + t.date + "\t" + t.inc + "\t" + t.outc);
            }
            dataGridView1.DataSource = union_res;
        }
        private void Q29_P()
        {
            Console.WriteLine(Environment.NewLine + "Q29_P" + Environment.NewLine);
            DataBaseDataContext context = new DataBaseDataContext();

            var union_V2 = (
                    from i1 in context.Income_o
                    from o1 in context.Outcome_o.Where(x => i1.point == x.point && i1.date == x.date).DefaultIfEmpty()
                    select new {i1.point, i1.date, inc = (decimal?) i1.inc, outc = (decimal?) o1.@out}).AsParallel()
                .Union((
                    from o1 in context.Outcome_o
                    from i1 in context.Income_o.Where(x => o1.point == x.point && o1.date == x.date).DefaultIfEmpty()
                    select new {o1.point, o1.date, inc = (decimal?) i1.inc, outc = (decimal?) o1.@out}).AsParallel());
            
            

            foreach (var t in union_V2)
            {
                Console.WriteLine(t.point + "\t" + t.date + "\t" + t.inc + "\t" + t.outc);
            }
            var unList = union_V2.ToList();
            dataGridView1.DataSource = unList;
        }
        private void Q30()
        {
            Console.WriteLine(Environment.NewLine + "Q30" + Environment.NewLine);

            DataBaseDataContext context = new DataBaseDataContext();

            Console.WriteLine(Environment.NewLine + "INCOME" + Environment.NewLine);

            var res_income = context.Income.GroupBy(i => new { i.point, i.date }).Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = (decimal?)0.0m,
                s_i = (decimal?)i.Sum(s => s.inc)
            }).OrderBy(o => o.point).ThenBy(o => o.date);
            foreach (var inco in res_income)
            {
                Console.WriteLine(inco.point + "\t" + inco.date + "\t" + inco.s_o + "\t" + inco.s_i);
            }

            Console.WriteLine(Environment.NewLine + "OUTCOME" + Environment.NewLine);

            var res_outcome = context.Outcome.GroupBy(i => new { i.point, i.date }).Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = (decimal?)i.Sum(s => s.@out),
                s_i = (decimal?)0.0m
            }).OrderBy(o => o.point).ThenBy(o => o.date);
            foreach (var outco in res_outcome)
            {
                //Console.WriteLine("FORECH");

                Console.WriteLine(outco.point + "\t" + outco.date + "\t" + outco.s_o + "\t" + outco.s_i);

            }

            Console.WriteLine(Environment.NewLine + "UNION" + Environment.NewLine);

            var union = res_income.Union(res_outcome).GroupBy(i => new { i.point, i.date }).Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = i.Sum(s => s.s_o),
                s_i = i.Sum(s => s.s_i),
            }).OrderBy(o => o.point).ThenBy(o => o.date);

            foreach (var row in union)
            {
                //Console.WriteLine("FORECH");
                Console.WriteLine(row.point + "\t" + row.date + "\t" + row.s_o + "\t" + row.s_i);
            }

            var union_null = union.Select(s => new
            {
                Point = s.point,
                Date = s.date,
                Outcome = s.s_o == 0.0m ? null : s.s_o,
                Income = s.s_i == 0.0m ? null : s.s_i
            });

            Console.WriteLine(Environment.NewLine + "UNION_NULL" + Environment.NewLine);

            foreach (var row in union_null)
            {
                //Console.WriteLine("FORECH");
                Console.WriteLine(row.Point + "\t" + row.Date + "\t" + row.Outcome + "\t" + row.Income);
            }
            dataGridView1.DataSource = union_null;
        }
        private void Q30_P()
        {
            Console.WriteLine(Environment.NewLine + "Q30_P" + Environment.NewLine);

            DataBaseDataContext context = new DataBaseDataContext();

            Console.WriteLine(Environment.NewLine + "INCOME" + Environment.NewLine);

            var res_income = context.Income.GroupBy(i => new { i.point, i.date }).AsParallel().Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = (decimal?)0.0m,
                s_i = (decimal?)i.Sum(s => s.inc)
            }).OrderBy(o => o.point).ThenBy(o => o.date);
            foreach (var inco in res_income)
            {
                Console.WriteLine(inco.point + "\t" + inco.date + "\t" + inco.s_o + "\t" + inco.s_i);
            }

            Console.WriteLine(Environment.NewLine + "OUTCOME" + Environment.NewLine);

            var res_outcome = context.Outcome.GroupBy(i => new { i.point, i.date }).AsParallel().Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = (decimal?)i.Sum(s => s.@out),
                s_i = (decimal?)0.0m
            }).OrderBy(o => o.point).ThenBy(o => o.date);
            foreach (var outco in res_outcome)
            {
                //Console.WriteLine("FORECH");

                Console.WriteLine(outco.point + "\t" + outco.date + "\t" + outco.s_o + "\t" + outco.s_i);

            }

            Console.WriteLine(Environment.NewLine + "UNION" + Environment.NewLine);

            var union = res_income.Union(res_outcome).GroupBy(i => new { i.point, i.date }).Select(i => new
            {
                point = i.Key.point,
                date = i.Key.date,
                s_o = i.Sum(s => s.s_o),
                s_i = i.Sum(s => s.s_i),
            }).AsParallel().OrderBy(o => o.point).ThenBy(o => o.date);

            foreach (var row in union)
            {
                //Console.WriteLine("FORECH");
                Console.WriteLine(row.point + "\t" + row.date + "\t" + row.s_o + "\t" + row.s_i);
            }

            var union_null = union.Select(s => new
            {
                Point = s.point,
                Date = s.date,
                Outcome = s.s_o == 0.0m ? null : s.s_o,
                Income = s.s_i == 0.0m ? null : s.s_i
            });

            Console.WriteLine(Environment.NewLine + "UNION_NULL" + Environment.NewLine);

            foreach (var row in union_null)
            {
                //Console.WriteLine("FORECH");
                Console.WriteLine(row.Point + "\t" + row.Date + "\t" + row.Outcome + "\t" + row.Income);
            }

            var unList = union_null.ToList();
            dataGridView1.DataSource = unList;
            dataGridView1.Update();
            if(
                dataGridView1.InvokeRequired)
                MessageBox.Show("INVOKE!!!");
        }
        
        private void btn_Q29_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if(!checkBox_Plinq.Checked)
                Q29();
            else
            {
                Q29_P();
            }
            watch.Stop();
            textBox_time.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btn_Q30_Click(object sender, EventArgs e)
        { 
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if(!checkBox_Plinq.Checked)
                Q30();
            else
            {
                Q30_P();
            }
            watch.Stop();
            textBox_time.Text = watch.ElapsedMilliseconds.ToString();
        }
    }
}
