using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Person("person1", 30));
            Node n2 = new Node(new Person("person2", 28));
            Node n3 = new Node(new Person("person3", 26));
            Node n4 = new Node(new Person("person4", 24));
            Node n5 = new Node(new Person("person5", 22));
            Node n6 = new Node(new Person("person6", 20));
            Node n7 = new Node(new Person("person7", 18));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            AbstractVisitor visitor = new AgeVisitor();
            Console.WriteLine(visitor.TotalAgeVisitor(n1));
        }
    }
}
