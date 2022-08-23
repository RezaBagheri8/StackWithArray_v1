using StackWithArray;

var stack = new Stack(4);

stack.Push(12);
stack.Push(3);
stack.Push(2);
stack.Push(90);
stack.Push(90);

stack.Pop();
stack.Pop();

stack.Print();
