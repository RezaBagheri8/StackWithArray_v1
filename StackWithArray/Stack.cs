using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    public class Stack
    {
        public int size;
        public int top;
        public int[] stack;

        public Stack(int sizeOfStack)
        {
            size = sizeOfStack;
            top = -1;
            stack = new int[size];
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("stack is full");
            }

            else
            {
                top++;
                stack[top] = item;
            }
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the stack is empty");
            }
            else
            {
                int result = stack[top];
                Console.WriteLine(result);
                top--;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the stack is empty!");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }

        }

        private bool IsFull()
        {
            if (top == (size - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsEmpty()
        {
            if (top == -1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
