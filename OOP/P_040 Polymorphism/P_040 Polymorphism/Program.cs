namespace P_040_Polymorphism
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Interfaces and Polymorphism!");

            SecondExampleOfInterfaces();
            Console.WriteLine("---------------------");
            SecondExampleShopInterfaces();
        }

        #region FirstExampleOfInterfaces

        // Deklaruojame kontrakta, kuri privalo igyvendinti BETKOKIA klase, kuri paveldeja si inteface
        // Viskas ka mes apsirasome igyvendinti PRIVALO buti public
        public interface INameable
        {
            // Mes privalome tureti paveldejancioje klaseje property pavadinimu Name su get ir set metodais
            string Name { get; set; }
            // Mes privalome turetu paveldejancioje klaseje void metoda pavadinimu PrintName()
            void PrintName();
        }

        public interface IColoreable
        {
            public string Color { get; set; }
        }

        public class C : INameable, IColoreable
        {
            public string Name { get; set; }
            private string color;

            public string Color
            {
                get { return color + " colorification"; }
                set { color = value; }
            }


            public void PrintName()
            {
                Console.WriteLine($"{Name} - {Color}");
            }
        }

        public class D
        {
            // Klases kontrakto dalis yra VISKAS KAS YRA PUBLIC
            public string Color { get; set; } // Klases kontrakto dalis
            private List<INameable> _items = new List<INameable>();
            public void AddItem(INameable itemWithName) // Klases kontrakto dalis
            {
                _items.Add(itemWithName);
            }

            public void PrintItems()
            {
                foreach (INameable item in _items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        public class A : C
        {
            public A()
            {
                Name = "A";
                Color = "Green";
            }

            public string Type { get; set; }
        }

        public class B : INameable
        {
            public B()
            {
                Name = "B";
            }

            public string Name { get; set; }

            public void PrintName()
            {
                throw new NotImplementedException();
            }
        }

        public static void FirstBasicInterfaceExample()
        {
            // Inicializuojame A klase kaip objekta, kurio veiksnumas yra apibreztas TIK INameable interface dalyje
            // Pasiekti kitu A klases atributu mes nebegalime, nes mes apibreziame interface scope ()
            INameable a1 = new A()
            {
                Name = "A",
                Color = "Green"
            };

            A a2 = new A()
            {
                Name = "A2",
                Color = "Teal"
            };

            A a3 = new A()
            {
                Name = "A3",
                Color = "Purple"
            };

            // a1.Color = "Blue"; // Nevalidu, nes Color nepakliuna po kontrakto/interface INameable dalimi.
            a2.Color = "Blue";


            INameable b1 = new B();

            D d1 = new D();
            d1.AddItem(a1);
            d1.AddItem(b1);
        }

        #endregion

        #region SecondExampleOfInterfaces
        public interface IPurchasable
        {
            string Name { get; }
            double Price { get; set; }
            int Discount { get; }
            void ChangeDiscount(int discountPercentage);
            void PrintLabel();
        }
        public class Food : IPurchasable, IEquatable<Food>, IEquatable<A>
        {
            public Food()
            {

            }
            public Food(string type)
            {
                Type = type;
                Console.WriteLine($"Constroctor from food was called. Type was set to: {Type}");
            }
            public Food(string type, string name)
            {
                Type = type;
                Name = name;
                Console.WriteLine($"Constroctor from food was called. Type was set to: {Type} name was set to : {Name}");
            }
            public string Type { get; set; }

            //interface dalis
            public string Name { get; protected set;}
            //interface dalis
            public double Price { get; set; }
            //interface dalis
            public int Discount { get; protected set;}
            //interface dalis
            public void ChangeDiscount(int discountPercentage)
            {
                Discount = discountPercentage; 
            }

            public bool Equals(Food other) => other.Type == Type;

            public bool Equals(A other) => other.Type == Type;

            public void PrintLabel()
            {
                Console.WriteLine($"Food product {Name}:{Type} is priced ad {Price} ");            
            }
        }
        public class Apple : Food
        {
            public Apple()
            {

            }
            public Apple(string color, int quality, int size) : base("Fruit")
            {
                Color = color;
                Quality = quality;
                Size = size;
            }

            public string Color { get; }
            public int Quality { get; }
            public int Size { get; private set; }
            public void ChangeSize(int newSize)
            {
                Size = newSize;
            }
        }

        public class Pizza : Food
        {
          
            public Pizza() : base("Pizza")
            {
                Console.WriteLine("Constructor from Pizza was called");
            }

            public Pizza(string name) : base("Pizza", name)
            {
            }
            public string CompanyName { get; set; }
        }
        public class Furniture : IPurchasable
        {
            public Furniture()
            {

            }
            public Furniture(string name)
            {
                Name = name;
            }

            public string Color { get; protected set; }
            public string Material { get; protected set; }

            //interface dalis
            public string Name { get; protected set; }
            //interface dalis
            public double Price { get; set; }
            //interface dalis
            public int Discount { get; protected set; }
            //interface dalis

            public void ChangeDiscount(int discountPercentage)
            {
                Discount = discountPercentage;
            }

            public void PrintLabel()
            {
                Console.WriteLine($"Food product {Name}:{Material} is priced ad {Price} ");
            }
        }
        public class Chair : Furniture
        {
            public Chair()
            {

            }
            public Chair (string color, string material, string name) : base(name)
            {
                Color = color;
                Material = material;
            }
        }
        public interface IAccount
        {
            string BankNo { get; }
            string OwnerName { get; }
            string GetAccountInfo();
            double Withdraw(double money);
            double TransferMoney(double money);
        }
        public interface ICart
        {
            public void AddToCart(IPurchasable product);
            public void Purchase(IAccount account);
            public void PrintItemList();
        }
        public class Cart : ICart
        {
            public void AddToCart(IPurchasable product)
            {
                throw new NotImplementedException();
            }

            public void PrintItemList()
            {
                throw new NotImplementedException();
            }

            public void Purchase(IAccount account)
            {
                throw new NotImplementedException();
            }
        }

        public static void SecondExampleOfInterfaces()
        {
            Food burger = new Food("Burger");
            Food pizza1 = new Food("Pizza");
            Food pizza2 = new Food("Pizza");

            Console.WriteLine($"Is burger == pizza {burger.Equals(pizza1)}");
            Console.WriteLine($"Is pizza1 == pizza2 {pizza1.Equals(pizza2)}");
        }

        public static void SecondExampleShopInterfaces()
        {
            Apple redApple = new Apple("Red", 4, 4);
            //Naudojan t Interface mes negalime pasiekti Color, Quality ir Size
            IPurchasable greenApple = new Apple("Green", 4, 3);
            redApple.ChangeSize(3);
            //greenApple.ChangeSize(4); //Negalima igyvendinti del to, kad tai nera kontrakto dalis
            greenApple.Price = 0.89;

            //kada mes kaireje puseje deklaruojam class varda, siuo atveju <Pizza> mes galime pasiekti visus egzistuojancius atributus <Pizza>
            // ir paveldejimose klasese (siuo atveju mes galime pasiekti ir <Pizza> atributus ir <Food> atributus ir <Object atributus>)
            Pizza ItalianPizza = new Pizza("Le Express");
            //Kada mes kaireje puseje deklaruiojame Interface varda, siuo atveju <IPurchasable> mes galime pasiekti TIK 
            IPurchasable americanPizza = new Pizza("Americano");
            IPurchasable blueDenimChair = new Chair("Denim", "Plastic", "Denimo");
        }


        #endregion
    }

}

