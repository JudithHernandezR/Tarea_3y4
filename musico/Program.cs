using System;
using System.Collections.Generic;
abstract class Musico
{
public string nombre;
public Musico (string n)
{
nombre = n;
}
public abstract String Afina(); 
public string Display()
{ 
return nombre;
}
}
class Bajista: Musico
{
public string instrumento;
public Bajista (string n, string i ):base(n)
{ 
instrumento=i;
}
public override String Afina()
{
    return String.Format("{0} se despide tocando {1}",nombre,instrumento);
}
}
class Guitarrista :Musico
{
public string instrumento;
public Guitarrista (string n, string i ):base(n)
{ 
instrumento=i;
}
public override String Afina()
{
    return String.Format("{0} se despide tocando {1}",nombre,instrumento);
}
}

// Falta el constructor y otras cosas??
class Program
{
static void Main(string[] args)
{
Bajista b = new Bajista("Flea","Bajista");
Guitarrista g = new Guitarrista("Santana","Guitarra");
Musico [] m=new Musico[2];

m[0] = b;
m[1] = g;

        
foreach (  Musico ms in m)
Console.WriteLine(ms.Afina());
Console.ReadKey();
}
}


