using Assignment01Advanced.BaseClass_Constraint;
using Assignment01Advanced.IReposatory_Example;
using Assignment01Advanced.Multi_Constraint;
using Assignment01Advanced.NewConstraints9;
using Assignment01Advanced.Question03;
using Assignment01Advanced.Question04;
using Assignment01Advanced.StructExample7;
using Assignment01Advanced.Swap;
using System.ComponentModel;

namespace Assignment01Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*

             Q1: What is a generic class? Why use generics?

            ans => It is a class capable of work with different data type;
            we use generics to avoid runtime errors,
            ensuring that any data type issues are detected at compile time.

             */
            #endregion

            #region Question02

            ///*
            // Q2: Write a generic class Container<T> with Add and Get methods.
            //*/
            //Containers<int> co = new Containers<int>();
            //co.Add(1);
            //co.Add(2);
            //co.Add(3);
            //Console.WriteLine($"index 1 is : {co.Get(1)}");//2
            //Console.WriteLine(co);//2

            #endregion

            #region Question03

            /*
             Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
             */

            //Pair<int, string> p = new Pair<int, string>(1, "ahmed");
            //Console.WriteLine($" Key is : {p.Key}\n Value is : {p.Value}");

            #endregion

            #region Question04

            ///*
            // Q5: Write a generic method FindMax<T> that finds maximum value
            // */

            //int[] arr = { 5, 2, 8, 87, -15, 7 };
            //if (arr.Length == 0)
            //    throw new ArgumentException("Array cannot be empty");
            //Search se = new Search();
            //Console.WriteLine($"max num is : {se.FindMax(arr)}");

            #endregion

            #region Question05

            // Q4: What is a generic method? Write Swap<T> method.

            //int x = 5 , y = 10;

            //SearchClass.Swap(ref x, ref y);
            //Console.WriteLine($"x after swap : is {x}\ny after swap : is {y} ");

            #endregion

            #region Question06

            //
            /*
            // Q6: What is a generic interface? Write IRepository<T>.

            //ans => A generic interface is an interface that can work with different data types
            //using type parameters. Any class that implements
            //it must provide implementations for its members using the specified type.
            */

            //IRepository< Product > pro = new RepositoryProduct();
            // pro.Add(new Product(1, "Laptop", 11000));
            // pro.Add(new Product(2, "smartWatch", 1000));
            // pro.Add(new Product(3, "mouse", 50));
            // foreach (var item in pro.GetAll())
            // {
            //     Console.WriteLine($" Id : {item.Id}\n Name : {item.Name}\n Price : {item.Salary}");
            // }
            // Console.WriteLine("after deleted=====================================");
            // pro.Delete(2);

            // foreach (var item in pro.GetAll())
            // {
            //     Console.WriteLine($" Id : {item.Id}\n Name : {item.Name}\n Price : {item.Salary}");
            // }
            #endregion

            #region Question07

            //Q7: What is the 'struct' constraint? Write an example.

            //The struct constraint specifies that the generic type parameter
            //must be a non-nullable value type

            // Console.WriteLine(MaxClass<int>.max(5, 10)); // valid => value type

            //// Console.WriteLine(MaxClass<string>.max("Ahmed" ,"yousef"));// not valid => reference type


            #endregion

            #region Question08

            // Q8: What is the 'class' constraint? Write an example.

            // ans => The class constraint specifies that the generic type parameter must be a reference type

            //Product pro = new Product(1, "Laptop", 14000);
            //ClassConstraint<Product> cl = new ClassConstraint<Product>(pro);
            //Console.WriteLine(cl.Value.Name); // valid => reference type

            ////ClassConstraint<int> cl = new ClassConstraint<int>(3);
            ////Console.WriteLine(cl.Value); //not valid => value type

            #endregion

            #region Question09

            // Q9: What is the 'new()' constraint? Write an example.
            //The type I pass must have a public parameterless constructor.

            //NewConstraint<Product> pro = new NewConstraint<Product>();
            //Product product = new Product();
            //product = pro.New();
            //product.Name = "mousef";
            //Console.WriteLine(product.Name);

            // NewConstraint<string> pro = new NewConstraint<string>(); not contain default constructor

            #endregion

            #region Question10

            //// Q10:  What is the interface constraint? Write an example.
            ////  ans => The type I'm going to send must implement the interface.

            //int[] IntArr = { 50, 6, 0, 4, 84, 21 };
            //Console.WriteLine(Search2.FindMax(IntArr));


            #endregion

            #region Question11

            //Q11: What is the base class constraint? Write an example.

            // ans=>  The type you pass must inherit from the class specified in the constraint.

            //Cat<Dog> cat = new Cat<Dog>("meoo");
            ////  Cat<Lion> lion = new Cat<Lion>(); // error => not Inheret from Animal class
            //Console.WriteLine(cat.Speak);
            #endregion

            #region Question12

            //Q12: How do you apply multiple constraints? Write an example.

            // ans via Comma Seperator

            User<Product> pro = new User<Product>(1, "Ahmed");

            pro.ValuesBuy.Id = 1;
            pro.ValuesBuy.Name = "mouse";
            pro.ValuesBuy.Salary = 1000;
            Console.WriteLine(pro);

            #endregion

        }
    }
}
