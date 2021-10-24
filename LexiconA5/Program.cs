using LexiconA5.Products;
using System;

namespace LexiconA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DemoRun();
           
        }

        private static void DemoRun()
        {
            Console.WriteLine(VendingMachine.CreateChangeString(800));

            Console.WriteLine(VendingMachine.CreateChangeString(995));
            Console.WriteLine(VendingMachine.CreateChangeString(39));

            VendingMachine vm = new VendingMachine();
            TestProducts tp = new TestProducts();
            vm.AddProduct(tp.stratos);
            vm.AddProduct(tp.caramel);
            vm.AddProduct(tp.coco);
            vm.AddProduct(tp.lion);
            vm.AddProduct(tp.coco);
            vm.AddProduct(tp.lion);

            vm.AddProduct(tp.coke);
            vm.AddProduct(tp.fanta33);
            vm.AddProduct(tp.coke);
            vm.AddProduct(tp.fanta33);
            vm.AddProduct(tp.fanta50);

            Console.WriteLine(vm.ShowAll()  ); 

            Console.WriteLine("Buy fanta 50cl (no cash)");
            Console.WriteLine(vm.Purchase(tp.fanta50));
            Console.WriteLine("Add 1x1000");
            vm.InsertMoney(1000);

            Console.WriteLine(  vm.Purchase(tp.fanta50));

            vm.EndTransaction();

            Console.ReadKey();
        }


    }


}
