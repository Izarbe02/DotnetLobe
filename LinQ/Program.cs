//                https://www.tutorialsteacher.com/linq/sample-linq-queries
//              https://www.tutorialsteacher.com/linq/linq-operators		
//				https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/features-that-support-linq
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void filtrarNumeros()
    {
        // Crea una lista de números
        List<int> numeros = new List<int> [ 1, 2, 3, 6, 7, 8, 4, 5 ];

        // filtra los números mayores que 5
        var numerosFiltrados = from n in numeros
                                where n > 5
                                select n;

        // imprime números filtrados
        Console.WriteLine("Números mayores que 5:");
        foreach (var numero in numerosFiltrados)
        {
            Console.WriteLine(numero);
        }
    }
//--------------------------------//--------------------------------

                  static void filtrarMamiferos() {
                //funcion de filrado de mamiferos
            static void filtrarAnimales()
            {
                List<string> animales = new List<string> [ "Oso", "Perro", "Cacatua", "Serpiente", "Iguana" ];

                var animalesMamiferos = from animal in animales
                                        where animal.ToLower().Contains("i")
                                        select animal;

                Console.WriteLine("Animales mamíferos:");
                foreach (var animal in animalesMamiferos)
                {
                    Console.WriteLine(animal);
                }
            }
		}

			/*lisMensajes.ForEach(item => Console.WriteLine(item.Asunto));
      foreach (var item in lisMensajes)*/
					
		// Student collection
		IList<Student> studentList = new List<Student>() { 
			new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
		};
		

		stundentList.foreach(item => Console.WriteLine(item.Name));
		foreach (var item in  studentList){
			Console.WriteLine($"\Alumno con nombre  {item.Name} y edad {item.Age}, con Id {item.StudentID} y edad {item.edad}");

		}

		/*var item = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StudentID > 0)
                              .Select(s => s.StudentName);*/
        }

//Expressions as DATA
/*Elmetodo (QueryMethod1) da una query como valor como valor de retorno*/
		IEnumerable<string> QueryMethod1(int[] ints) =>
			from i in ints
			where i > 4
			select i.ToString();

			
//Elmetodo (QueryMethod2) devuelve una query como un parámetro de salida
//En ambos casos lo que se devuelve es la query, no el valor de esta

		void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
			returnQ =
				from i in ints
				where i < 4
				select i.ToString();

					myQuery1 =
				from item in myQuery1
				orderby item descending
				select item;

			// Execute the modified query.
			Console.WriteLine("\nResults of executing modified myQuery1:");
			foreach (var s in myQuery1)
			{
				Console.WriteLine(s);
			}
		

