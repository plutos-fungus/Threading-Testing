﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace MathWithThreading
{
    public class Threads1
    {
        Stopwatch stopwatch = new Stopwatch();
        public List<int> thread1 = new List<int>();
        public List<int> thread2 = new List<int>();
        public List<int> thr1 = new List<int>();
        public List<int> thr2 = new List<int>();
        public List<int> thr3 = new List<int>();
        public List<int> thr4 = new List<int>();
        public List<int> Final = new List<int>();
        public void Loader(int amount)
        {
            //using (StreamReader sr = new StreamReader("hej.csv"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        thread1.Add(Convert.ToInt32(sr.ReadLine().Trim(',')));
            //    }
            //}
            //using (StreamReader sr = new StreamReader("hej.csv"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        thread2.Add(Convert.ToInt32(sr.ReadLine().Trim(',')));
            //    }
            //}

            for (int i = 0; i < amount; i++)
            {
                thread1.Add(i);
            }
            for (int i = 0; i < amount; i++)
            {
                thread2.Add(i);
            }
        }

        public void Divider()
        {
            for (int i = 0; i < thread1.Count(); i++)
            {
                if (thr1.Count() < thread1.Count() / 2)
                {
                    thr1.Add(thread1[i]);
                }
                else
                {
                    thr2.Add(thread1[i]);
                }
            }
            for (int i = 0; i < thread2.Count(); i++)
            {
                if (thr3.Count() < thread2.Count() / 2)
                {
                    thr3.Add(thread2[i]);
                }
                else
                {
                    thr4.Add(thread2[i]);
                }
            }
        }

        public void Threads()
        {
            Thread tr1 = new Thread(Calc1);
            Thread tr2 = new Thread(Calc2);
            Thread tr3 = new Thread(Calc3);
            Thread tr4 = new Thread(Calc4);

            stopwatch.Start();

            tr1.Start();
            tr2.Start();
            tr3.Start();
            tr4.Start();
            
            tr1.Join();
            tr2.Join();
            tr3.Join();
            tr4.Join();

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " " + "4 threads");
            stopwatch.Reset();
        }

        public void Calc1()
        {
            for (int i = 0; i < thr1.Count(); i++)
            {
                //Final.Add(thr1[i] * thr2[i] + i);
                Final.Add(thr1[i].GetHashCode());
            }
        }

        public void Calc2()
        {
            for (int i = 0; i < thr2.Count(); i++)
            {
                //Final.Add(thr1[i] * thr2[i] + i);
                Final.Add(thr2[i].GetHashCode());
            }
        }

        public void Calc3()
        {
            for (int i = 0; i < thr3.Count(); i++)
            {
                Final.Add(thr3[i].GetHashCode());
            }
        }

        public void Calc4()
        {
            for (int i = 0; i < thr4.Count(); i++)
            {
                Final.Add(thr4[i].GetHashCode());
            }
        }
    }
}
