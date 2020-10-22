using System;


public class Producto // Clase padre
{
  public int cantidad;   //atributos

  public int Getcantidad()
  {
    return cantidad;
  }
   
  public void Setcantidad (int nuevacanti)
  {
    cantidad=nuevacanti;
  }

  public void Mostrarestado() //funcion
 {
  Console.WriteLine("Actualmente tenemos {0} productos, chocolates, caramelos, chicles y alfajores",cantidad);
 }
}


public class Chocolate : Producto  // Clase que hija que hereda de Producto

{
  string color;  
  //int cantchoco;
  

  public string Getcolor()
  {
    return color;
  }
   
  
  public void Setcolor (string nuevocolor)
  {
    color=nuevocolor;
  }
  
  
  public new void Mostrarestado()  // funcion
  {
  Console.WriteLine("Si le interesa los chocolates tenemos {0} chocolates {1} en oferta",cantidad,color);
  }

  public void Mostrarsaldochoco()// funcion
  {
  Console.WriteLine("Aun nos quedan {0} chocolates {1} en oferta",cantidad,color);
  } 
}

public class Ejemplo
{
  public static void Main () 
  {
    int pedidocho;
    int eleccho;
    Producto p = new Producto();
    p.Setcantidad(4);
    p.Mostrarestado();
    Chocolate p2 = new Chocolate();
    p2.Setcantidad(30);
    p2.Setcolor("blancos");
    p2.Mostrarestado();
    Console.WriteLine("Si quiere chocolates ingrese 1");
    eleccho=Convert.ToInt32(Console.ReadLine());
    
    if (eleccho == 1)
      {
      Console.WriteLine("Cuantos desea");
      pedidocho=Convert.ToInt32(Console.ReadLine());
      
      while (pedidocho>p2.cantidad)
       {
        Console.WriteLine("No tenemos tantos, lo maximo que tenemos es {0}",p2.cantidad);
        Console.WriteLine("Por favor ingrese otra cantidad");
        pedidocho=Convert.ToInt32(Console.ReadLine());
          
       }
      p2.cantidad= p2.cantidad-pedidocho;
      p2.Mostrarsaldochoco();


      //Console.WriteLine("Quiere otro producto?");

    //else
      Console.WriteLine("Hay que seguir el desarrollo");
            
      }

        //Console.WriteLine("Quiere otro producto?");
   // }
      
    //if (pedidoocho > p2.cantidad)
   // Console.WriteLine("Lo siento no tenemos mas");

  }
}
