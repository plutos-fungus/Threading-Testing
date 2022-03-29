// See https://aka.ms/new-console-template for more information
using MathWithThreading;
int amount = 50000000;

Threads2 tr2 = new Threads2();
tr2.Loader(amount);
tr2.Divider();
tr2.Threads();

tr2.thread1.Clear();
tr2.thread2.Clear();
tr2.thr1.Clear();
tr2.thr2.Clear();
tr2.thr3.Clear();
tr2.thr4.Clear();

Threads1 tr1 = new Threads1();
tr1.Loader(amount);
tr1.Divider();
tr1.Threads();

tr1.thread1.Clear();
tr1.thread2.Clear();
tr1.thr1.Clear();
tr1.thr2.Clear();
tr1.thr3.Clear();
tr1.thr4.Clear();

Console.ReadLine();

