using System;

abstract class A
{
    public abstract void method1();
    public abstract void method3();

    public void method2()
  {
      Console.WriteLine("I am a non-abstract method from abstract class");
   }
    
}

class B : A
{
    public override void method1()
    {
        Console.WriteLine("I am an abstract method overrriden at class B");
    }
    override public void method3()
    {

    }
    //write your code here
}

public class AbstractClassExample
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.method1();
        obj.method2();
        Console.ReadLine();
        //write your code here
    }

}
