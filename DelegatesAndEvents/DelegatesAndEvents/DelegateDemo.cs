using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public delegate int operations(int x, int y);
    class DelegateDemo
    {
        public static int Addition(int a,int b)
        {
            return a + b;
        }
    }
}
