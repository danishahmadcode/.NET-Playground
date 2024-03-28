namespace mainNamespace{
    using arithmetic;
    using relational;
    using logical;
    using tryCatchExample;
    class MyMainClass{
    static void Main(string[] args)
    {
        ArithmeticOperations aOperation = new ArithmeticOperations();
        Console.WriteLine(aOperation.PlusOperator(100,20));
        Console.WriteLine(aOperation.MinusOperator(10,20));
        Console.WriteLine(aOperation.DivideOperator(100,20));
        Console.WriteLine(aOperation.MultiplyOperator(10,20));
        Console.WriteLine(aOperation.ModulusOperator(10,20));
        RelationalOperations rOperation = new RelationalOperations();
        Console.WriteLine(rOperation.greaterThanOperator(30,60));
        Console.WriteLine(rOperation.lessThanOperator(30,60));
        Console.WriteLine(rOperation.greaterOrEqualToOperator(30,60));
        Console.WriteLine(rOperation.lessOrEqualToOperator(30,60));
        Console.WriteLine(rOperation.equalToOperator(30,60));
        Console.WriteLine(rOperation.notEqualToOperator(30,60));
        LogicalOperations lOperation = new LogicalOperations();
        Console.WriteLine(lOperation.andOperator(true,true));
        Console.WriteLine(lOperation.orOperator(true,true));
        Console.WriteLine(lOperation.notOperator(false));
        TryCatchClass.RunTryCatchExample();
    }
    }
}

