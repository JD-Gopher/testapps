﻿using System;
using static System.Console;

namespace spanforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // This app demonstrates various patterns for using
            // forach with ref structs.
            // ref structs cannot implement interfaces, so IEnumerable isn't an option
            int[] data = new int[] {0,1,2,3,4};
            var foo = new Foo(data);
            Span<int> data2 = data;
            var bar = new Bar(data2[2..^1]);

            WriteLine("foreach over foo");
            foreach (var f in foo)
            {
                Console.WriteLine(f);
            }

            WriteLine("foreach over bar");
            foreach (var b in bar)
            {
                Console.WriteLine(b);
            }

            WriteLine("foreach over a span");
            foreach (var s in data2)
            {
                Console.WriteLine(s);
            }

            WriteLine("foreach over two Foos");
            foreach(var f in new TwoFooHolder(foo,foo))
            {
                foreach(var num in f)
                {
                    WriteLine(num);
                }
            }

            WriteLine("indexer access over two Foos");
            var holder = new TwoFooHolder(foo,foo);
            for (int i = 0; i < 2;i++)
            {
                var f = holder[i];
                foreach(var num in f)
                {
                    WriteLine(num);
                }
            }
        }
    }
}

/*
foreach over foo
0
1
2
3
4
foreach over bar
2
3
foreach over a span
0
1
2
3
4
foreach over two Foos
0
1
2
3
4
0
1
2
3
4
*/
