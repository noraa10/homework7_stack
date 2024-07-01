using System;
using System.Collections.Generic;

public class StackOperations
{
    //1: Push and Pop elements from a stack
    static void PushPopElements()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Elements in the stack:");
        PrintStack(stack); // Output: 3 2 1

        int poppedElement = stack.Pop();
        Console.WriteLine("Popped element: " + poppedElement); // Output: 3

        Console.WriteLine("Elements in the stack after popping:");
        PrintStack(stack); // Output: 2 1
    }


    // Task 2: Check if a stack is empty
    static void CheckStackEmpty()
    {
        Stack<int> stack = new Stack<int>();

        if (stack.Count == 0)
        {
            Console.WriteLine("Is the stack empty? true");
        }
        else
        {
            Console.WriteLine("Is the stack empty? false");
        }

        stack.Push(1);
        stack.Push(2);

        if (stack.Count == 0)
        {
            Console.WriteLine("Is the stack empty? true");
        }
        else
        {
            Console.WriteLine("Is the stack empty? false");
        }
    }


    // Task 3: Get the size of the stack
    static void GetStackSize()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Size of the stack: " + stack.Count); // Output: 3
    }


    // Task 4: Peek the top element of the stack
    static void PeekTopElement()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        int topElement = stack.Peek();
        Console.WriteLine("Top element of the stack: " + topElement); // Output: 3

        Console.WriteLine("Elements in the stack:");
        PrintStack(stack); // Output: 3 2 1
    }


    // Task 5: Create a copy of the stack
    static void CopyStack()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Stack<int> copyStack = new Stack<int>(stack);

        Console.WriteLine("Original stack:");
        PrintStack(stack); // Output: 3 2 1
        Console.WriteLine("Copy of the stack:");
        PrintStack(copyStack); // Output: 3 2 1
    }


    // Task 6: Search for an element in the stack
    static void SearchElementInStack()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        int searchElement = 3;
        bool found = stack.Contains(searchElement);
        Console.WriteLine("Is " + searchElement + " found in the stack? " + found); // Output: true

        searchElement = 6;
        found = stack.Contains(searchElement);
        Console.WriteLine("Is " + searchElement + " found in the stack? " + found); // Output: false
    }


    // Task 7: Clear the stack
    static void ClearStack()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Elements in the stack before clearing:");
        PrintStack(stack); // Output: 3 2 1

        stack.Clear();

        Console.WriteLine("Elements in the stack after clearing:");
        PrintStack(stack); // Output: (no output)
    }


    // Task 8: Convert an array to a stack
    static void ConvertArrayToStack()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Stack<int> stack = new Stack<int>(array);

        Console.WriteLine("Elements in the stack:");
        PrintStack(stack); // Output: 5 4 3 2 1
    }


    // Task 9: Convert a stack to an array
    static void ConvertStackToArray()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        int[] array = stack.ToArray();

        Console.WriteLine("Elements in the array:");
        foreach (int element in array)
        {
            Console.Write(element + " "); // Output: 5 4 3 2 1
        }
        Console.WriteLine();
    }

    // print a stack
    static void PrintStack(Stack<int> stack)
    {
        Console.WriteLine("The contents of the stack are:");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        PushPopElements();
        CheckStackEmpty();
        GetStackSize();
        PeekTopElement();
        CopyStack();
        SearchElementInStack();
        ClearStack();
        ConvertArrayToStack();
        ConvertStackToArray();
        
    }
}