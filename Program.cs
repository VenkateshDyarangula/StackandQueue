﻿using System;

namespace UC1_PuchIntoStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList linkedListStack = new StackUsingLinkedList();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();

        }
    }
}