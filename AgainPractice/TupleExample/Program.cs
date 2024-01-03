// See https://aka.ms/new-console-template for more information
using TupleExample;

Console.WriteLine("Hello, World!");


Point point = new Point();
point.x = 10;
point.y = 20;

(int x, int y) pnt = (5, 1);

Customer[] customers = new Customer[3];
customers[0] = new Customer { Id = 1, Name = "Rajib Rari"};
customers[1] = new Customer { Id = 2, Name = "Rezaul Rari"};
customers[2] = new Customer { Id = 1, Name = "Naim Rari"};

Order[] order = new Order[3];
order[0] = new Order { CustomerId = 1, Amount = 200, OrderDate = DateTime.Now };
order[1] = new Order { CustomerId = 2, Amount = 400, OrderDate = new DateTime(2024,01,03)};
order[2] = new Order { CustomerId = 3, Amount = 600, OrderDate = DateTime.Now };

var r = from c in customers
        join o in order on c.Id equals o.CustomerId
        select (CustomerName : c.Name, PurchaseAmount : o.Amount); /*use Tuple*/
//select new OrderDetails { CustomerName = c.Name, Amount = o.Amount }; /*ata use korle Tuple projon hoy na*/

foreach (var item in r)
{
    Console.WriteLine($" Customer : {item.CustomerName}, Amount : {item.PurchaseAmount} ");
}


(int x, (string y, double z)) sample = (5, ("Rajib", 5.5));