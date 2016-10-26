namespace Playground.StudyCases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static System.Console; // Static members accessible via usin-static

    /// <summary>
    /// https://github.com/dotnet/roslyn/wiki/New-Language-Features-in-C%23-6
    /// </summary>
    internal static class CSharp60Features

    {
        private class Customer
        {
            public string Name { get; } = "John"; // inline initializers for auto-properties
            public string Surname { get; } = "Snow"; // inline initializers for auto-properties
            public Guid Id { get; } = Guid.Empty; // getter-only auto-property

            public IList<Order> Orders { get; } = new List<Order>();

            public string FullName => Name + " " + Surname; // lambda body for a property

            public Customer(string name, string surname, IList<Order> orders)
            {
                Id = Guid.NewGuid(); // getter-only auto-property is accessable from Constructor though..

                Name = name;
                Surname = surname;
                if (orders == null) throw new ArgumentNullException(nameof(orders)); // handy nameof expression here
                Orders = orders;
            }

            public override string ToString() => $"{FullName} [ID={Id}]"; // Hooray to string interpolation instead of string.Format

            public void HelloConsolePrint() => WriteLine($"Hello our dear customer {this.FullName}"); // lambda body for a class method, even though it's void one

            /// <summary>
            /// Check whether customer is entitled to 10% discount
            /// should have at least 5 orders each with a TotalSum more than 50$
            /// </summary>
            public bool IsEntitledForDiscount => Orders?.Where(o => o.Status == OrderStatus.Closed && o.TotalSum > 50)?.Count() > 3; // null conditional checks with ?

        }

        private class Order
        {
            public OrderStatus Status { get; set; } = OrderStatus.Open;
            public decimal TotalSum { get; set; }
        }

        private enum OrderStatus
        {
            Open,
            Closed
        }

        public static void RunAndExplore()
        {
            var dearCustomers = new Dictionary<string, Customer>
            {
                ["Jack"] = new Customer("Jack", "Davies", new List<Order> { new Order { Status = OrderStatus.Open, TotalSum = 75 } }),
                ["VIPClient"] = new Customer("George", "Berry", new List<Order>
                {
                    new Order { Status = OrderStatus.Closed, TotalSum = 175 },
                    new Order { Status = OrderStatus.Closed, TotalSum = 259 },
                    new Order { Status = OrderStatus.Closed, TotalSum = 315 },
                    new Order { Status = OrderStatus.Closed, TotalSum = 80 }
                })                
            };


            foreach (var ohDear in dearCustomers)
            {
                ohDear.Value.HelloConsolePrint();
                if (ohDear.Value.IsEntitledForDiscount) WriteLine($"\tDear {ohDear.Value.Name}, we glad to tell that you are our favorite and we give you 10% discount!");
            }


            Customer c;
            try
            {
                c = new Customer("Fredou", "Blanchard", null);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "orders") // say yo for exception filtering
            {
                WriteLine("Hey yo dude, it seems you haven't got any orders as a Customer, that's not valid for us. We're very sorry about that though");
            }

            Console.ReadKey();
        }
    }
}