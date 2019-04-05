using System;

namespace r
{
class A
{
public int a;
public A()
{
a = 10;
}
public virtual string Display()
{
return a.ToString();
}
}
class B:A
{
public int b;
public B():base()
{
b = 15;
}

// #########################################
// # Después de contestar la pregunta 1 
// # Redefine el método Display( ) en este espacio, debe regresar el campo b como string.
// #########################################
public override string Display()
{
return b.ToString();
}
}
class Program
{
static void Main(string[] args)
{
A objA = new A();
B objB = new B();
Console.WriteLine(objA.Display()); //// (1 )
Console. WriteLine(objB.Display()); //// ( 2)
}
}
}

