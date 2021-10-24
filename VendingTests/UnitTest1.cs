using System;
using Xunit;
using LexiconA5;
using LexiconA5.Model;
using LexiconA5.Products;


namespace VendingTests
{
    public class ProductClassShouldConsider
    {

        readonly Drink fanta50 = new Drink(20, "Fanta", "A tasty nazi concoction of leftover chemicals and fun colors. 50cl.", "Drink to get your sugar fix.");
        [Fact]
        public void CreateNewProduct()
        {
            Assert.Equal("Fanta", fanta50.Name);
        }

        [Fact]
        public void ShowUse()
        {
            Assert.Equal("Drink to get your sugar fix.", fanta50.Use());
        }

        [Fact]
        public void ShowDescription()
        {
            Assert.Equal("A tasty nazi concoction of leftover chemicals and fun colors. 50cl.", fanta50.Examine());
        }

        [Fact]
        public void ShowPrice()
        {
            Assert.Equal(20, fanta50.Price);
        }

        [Fact]
        public void EqualToSame()
        {
            Drink fanta50b = new Drink(20, "Fanta", "A tasty nazi concoction of leftover chemicals and fun colors. 50cl.", "Drink to get your sugar fix.");
            Assert.Equal(fanta50b, fanta50);
            Assert.True(fanta50b.Equals(fanta50));
        }

    }



    public class VendingMachineClassShouldConsider
    {
        VendingMachine vm;
        TestProducts tp;
        public VendingMachineClassShouldConsider()
        {
            vm = new VendingMachine();
            tp = new TestProducts();
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

        }

        [Fact]
        public void CreateNewVendingMachine()
        {
            VendingMachine TestVM = new VendingMachine();
            Assert.NotNull(TestVM);
        }

        [Fact]
        public void GiveChange()
        {
            string str = VendingMachine.CreateChangeString(995);
            Assert.Equal("Change (995kr):\r\n0x1000\r\n1x500\r\n2x200\r\n0x100\r\n1x50\r\n2x20\r\n0x10\r\n1x5\r\n0x2\r\n0x1\r\n", str);
        }

        [Fact]
        public void EndTransactionString()
        {
            string str = VendingMachine.CreateChangeString(980);
            vm.InsertMoney(1000);
            vm.Purchase(tp.fanta50);
            Assert.Equal(str, vm.EndTransaction());
        }



        [Fact]
        public void InsertMoney()
        {
            vm.InsertMoney(10);
            Assert.Equal(10, vm.GetDeposit);
            vm.InsertMoney(21);
            Assert.Equal(10, vm.GetDeposit);
            vm.InsertMoney(10);
            Assert.Equal(20, vm.GetDeposit);
        }

        [Fact]
        public void ShowAll()
        {            
            Assert.Equal("Currently available products:\r\nStratos: 69kr.\r\nCaramel: 13kr.\r\nCoco: 19kr.\r\nLion: 18kr.\r\nCoca-Cola: 15kr.\r\nFanta: 16kr.\r\nFanta: 20kr.\r\n", vm.ShowAll());
        }

        [Fact]
        public void AddProduct()
        {
            int prodNum = vm.NumberOfProducts();
            vm.AddProduct(tp.fanta50);
            Assert.Equal(prodNum + 1, vm.NumberOfProducts());
        }

        [Fact]
        public void PurchaseProduct()
        {
            int prodNum = vm.NumberOfProducts();
            vm.AddProduct(tp.fanta50);
            Assert.Equal(prodNum + 1, vm.NumberOfProducts());
            vm.Purchase(tp.fanta50);
            Assert.Equal(prodNum + 1, vm.NumberOfProducts());
            vm.InsertMoney(1000);
            vm.Purchase(tp.fanta50);
            Assert.Equal(prodNum, vm.NumberOfProducts());
        }

    }
}



