using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Lab
{
    internal class Stack : IStack
    {
        int[] arr;
        static int top;
        public Stack()
        {
            arr = new int[5];
            top = 0;
        }
        public void Pop()
        {
            if (top > 0)
                top--;
            else
                throw new Exception("There is no elements on stack");
        }

        public void Push(int item)
        {
            if (top == 5)
                throw new Exception("The Stack is Full");
            else
                arr[top++] = item;
        }
    }
}
