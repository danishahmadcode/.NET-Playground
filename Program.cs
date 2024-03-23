namespace Arithmetic{
public class Operations
{
    public int PlusOperator(int num1, int num2){
        return num1 + num2;
    }
    public int MinusOperator(int num1, int num2){
        return num1 - num2;
    }
    public int DivideOperator(int num1, int num2){
        return num1 / num2;
    }
    public int MultiplyOperator(int num1, int num2){
        return num1 * num2;
    }
    public int ModulusOperator(int num1, int num2){
        return num1 % num2;
    }    
}
}

namespace MainNamespace{
    using Arithmetic;
    class MyMainClass{
    static void Main(string[] args)
    {
        Operations value = new Operations();
        Console.WriteLine(value.PlusOperator(10,20));
        Console.WriteLine(value.MinusOperator(10,20));
        Console.WriteLine(value.DivideOperator(100,20));
        Console.WriteLine(value.MultiplyOperator(10,20));
        Console.WriteLine(value.ModulusOperator(10,20));
    }
    }
}

