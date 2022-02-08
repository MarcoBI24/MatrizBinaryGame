using System;
public class Programa
{
   
    public static void Main()
    {       

        // Reglas:
        // crear una matriz de 4x4 de ceros(Matriz inicial).
        // El jugador tedra 4 turnos para jugar
        // El jugador debera indicar las coodernadas (X,Y)
        // del digito que quiere cambiar de 0 a 1. Dicho digito cambiara a 1
        // y los ceros que se encuentren en todas las direcciones posibles
        //(Arriba, izquierda. derecha y abajo).
        // Gana uien logre convertir todos los ceros de la matriz en unos.










       
        //EJE Y 4
        int ejeY4=0;
        //EJE X 4
        int ejeX4=0;
        //EJE Y 3
        int ejeY3=0;
        //EJE X 3  
        int ejeX3=0; 
        //EJE Y 2
        int ejeY2=0;
        //EJE X 2
        int ejeX2=0;
        //EJE Y 1
        int ejeY1=0;
        //EJE X 1
        int ejeX1=0;
        //CREAR LA MATRIZ
        Console.WriteLine("MATRIZ");
        Console.WriteLine();

        for (int y =1; y <=4; y++)
        {
            for (int x = 1; x <= 4; x++)
            {
                Console.Write(0); 
                Console.Write(" ");        
            }
            Console.WriteLine();
        }
        //for para que solo tenga 4 intentos
        for (int i = 1; i <= 4; i++)

        {
            Console.WriteLine($"te quedan {4-i} intentos"); 
            Console.WriteLine();
            if (i==1)
            {
                //para que diga el ejeX 1
                Console.WriteLine($"DIGITE EL EJE X({i}): ");
                ejeX1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //para que diga el ejeY 1            
                Console.WriteLine($"DIGITE EL EJE Y({i}): ");
                ejeY1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            if(i==2)
            {
                //para que diga el ejeX 2
                Console.WriteLine($"DIGITE EL EJE X({i}): ");
                ejeX2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //para que diga el ejeY 2
                Console.WriteLine($"DIGITE EL EJE Y({i}): ");
                ejeY2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            if(i==3)
            {
                //para que diga el ejeX 3
                Console.WriteLine($"DIGITE EL EJE X({i}): ");
                ejeX3=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //para que diga el ejeY 3
                Console.WriteLine($"DIGITE EL EJE Y({i}): ");
                ejeY3=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            if(i==4)
            {
                //para que diga el ejeX 4
                Console.WriteLine($"DIGITE EL EJE X({i}): ");
                ejeX4=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //para que diga el ejeY 4
                Console.WriteLine($"DIGITE EL EJE Y({i}): ");
                ejeY4=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            //crea la matriz
            Console.WriteLine("MATRIZ");
            Console.WriteLine();
            //logica para que cree la matriz con X y Y
            for (int y =1; y <=4; y++)
            {
                
                if(y==ejeY1)
                {
                    for (int X = 1; X <= 4; X++)
                    {
                        //para que dibuje un 1 en el eje X1 y Y1
                        if(X==ejeX1 && y==ejeY1)
                        {
                            Console.Write(1);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(0); 
                            Console.Write(" ");
                        } 
                    }
                    
                    Console.WriteLine();
                    continue;
                    
                }
                if(y!=ejeY2 && y!=ejeY3 && y!=ejeY4)
                    {  
                     for (int X = 1; X <= 4; X++)
                        {
                            Console.Write(0); 
                            Console.Write(" ");
                        }
                    }
                //para que vea si y es igual al ejeY2 
                if(y==ejeY2)
                {
                    for (int X = 1; X <=4; X++)
                    {
                        //para que dibuje un 1 en el eje X2 y Y2
                        if(X==ejeX2 && y==ejeY2)
                        {
                            Console.Write(1);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(0); 
                            Console.Write(" ");
                        }

                    }
                    Console.WriteLine();
                    continue;
                        
                }
                
                if (y==ejeY3)
                {
                    for (int X = 1; X <= 4; X++)
                    {
                          //para que dibuje un 1 en el eje X3 y Y3
                        if(X==ejeX3 && y==ejeY3)
                        {
                                Console.Write(1);
                                Console.Write(" ");
                        }
                        else
                        {
                                Console.Write(0); 
                                Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    continue;
                       
                }
                
                if (y==ejeY4)
                {   
                    for (int X = 1; X <= 4; X++)
                    {
                         //para que dibuje un 1 en el eje X4 y Y4
                        if(X==ejeX4 && y==ejeY4)
                        {
                            Console.Write(1);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(0); 
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    continue;
                }
                
                Console.WriteLine();

            }
        }
       
          
        Console.ReadKey();
    }  
    
}
    