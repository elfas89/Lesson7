using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNamespace;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)


        {
            //1
            //int[] intArr = new int[10];
           
            //try
            //{
            //    int x = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("К типу привели");

            //    intArr[x] = 200;
            //    Console.WriteLine("Элемент задан успешно");
                

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("А это бочина с массивом");
            //}
            //catch (Exception exFull)
            //{
            //    Console.WriteLine("А это бочина");
            //}
            //finally
            //{
            //    Console.WriteLine("Это файналли, детка");
            //}

            //2
            //Speed s1 = new Speed();
            //try
            //{
            //    s1.Distance = 1;
            //    s1.Time = 0;
            //}
            //catch (DistanceException dex) {
            //    Console.WriteLine(dex.Message);
            //}
            //catch (TimeException tex)
            //{
            //    Console.WriteLine(tex.Message);
            //}
            //finally{}

            //3
            //Animal[] arrAnimal = new Animal[6];

            //arrAnimal[0] = new Dog { Name = "Шарик" };
            //arrAnimal[1] = new Cat { Name = "Кусака" };
            //arrAnimal[2] = new Cat { Name = "Ленивец" };
            //arrAnimal[3] = new Dog { Name = "Джек" };
            //arrAnimal[4] = new Cat { Name = "Черныш" };
            //arrAnimal[5] = new Dog { Name = "Арчи" };
            //foreach(Animal a in arrAnimal)
               //   {
                // Вызывает метод Bite у всех объектов в массиве arrAnimal
                     // a.Bite();


                //Вызывает метод Purr только у тех объектов, которые являются экземплярами класса Cat 
                //(данный пункт необходимо реализовать 3 способами).

                    //one
                      //Animal cat = a as Cat;
                      //if (cat != null)
                      //{
                      //    ((Cat)a).Purr();
                      //}

                    //two
                      //if (a is Cat)
                      //{
                      //    ((Cat)a).Purr();
                      //}
 
                    //three
                      //try
                      //{
                      //    ((Cat)a).Purr();
                      //}
                      //catch (InvalidCastException ex)
                      //{
                      //    Console.WriteLine(ex.Message);
                      //}
                  
                 // }

            //4
           //Library lib = new Library(3);
           //lib[0] = new Book("Книга №1");
           //lib[1] = new Book("Книга №2");
           //lib[2] = new Book("Книга №3");
           //Console.WriteLine(lib[0].Name);

            //?


            //5
            //var sex = new { Sex = "male"};
            //var person = new {Name = "Andy", Age = 26, Sex = sex };

            //Console.WriteLine(person.Name + " " + person.Age + " " + person.Sex);


            //6
            //TestNamespace.TestClass test = new TestNamespace.TestClass("Hi!");
            //Console.WriteLine(test.Name);

            //TestClass test = new TestClass("Hi with using!");
            //Console.WriteLine(test.Name);

        }
    }
}
