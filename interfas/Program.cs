using System;
using System.Collections.Generic;
interface IMusico
{

void Musico (string n);
String Afina(); 
string Display();

}
class Bajista: IMusico
{
    public string nombre;
    public void Musico (string n)
{
    nombre=n;
}
public string Display()
{ return nombre;
} 
public string instrumento;
public Bajista (string n, string i )
{ 
instrumento=i;
nombre=n;
}
public String Afina()
{
    return String.Format("{0} se despide tocando {1}",nombre,instrumento);
}
}
class Guitarrista :IMusico
{
    public string nombre;
    public void Musico (string n)
{
    nombre=n;
}
public string Display()
{ return nombre;
} 
public string instrumento;
public Guitarrista (string n, string i )
{ 
instrumento=i;
nombre=n;
}
public  String Afina()
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
IMusico [] m=new IMusico[2];

m[0] = b;
m[1] = g;

        
foreach (  IMusico ms in m)
Console.WriteLine(ms.Afina());
Console.ReadKey();
}
}
