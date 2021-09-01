using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class demo
    {
        private int _a;
        private int _b;

        public demo(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get => _a; set => _a = value; }
        public int B { get => _b; set => _b = value; }
    }
}
