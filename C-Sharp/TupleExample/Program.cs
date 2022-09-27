// See https://aka.ms/new-console-template for more information

using TupleExample;

Point p = new Point();
p.x = 5;
p.y = 10;

(int x, int y) point = (5,10);
Console.WriteLine(point.x);
Console.WriteLine(point.y);

Customers[] customers = new Customers[3];
customers[0] = new Customers { ID = 1, Name = "Md Rajib Rari"};
customers[1] = new Customers { ID = 2, Name = "Md Rajib"};
customers[2] = new Customers { ID = 3, Name = "Rajib Rari"};

Oders[] oders = new Oders[3];
oders[0] = new Oders { CustomerID = 1, Amount = 200, OrderDate = new DateTime(2022, 4, 5) };
oders[1] = new Oders { CustomerID = 2, Amount = 300, OrderDate = new DateTime(2022, 7, 5) };
oders[2] = new Oders { CustomerID = 3, Amount = 400, OrderDate = new DateTime(2022, 4, 9) };


var r = from c in customers
        join o in oders on c.ID equals o.CustomerID
        //select new Oderdeatils { CustomerName = c.Name, Amount = o.Amount };
        select (CustomerName:c.Name, PurchaseAmount:o.Amount);
foreach (var item in r)
{
    Console.WriteLine($"Customer: {item.CustomerName}, Amount:{item.PurchaseAmount}");
}


(int x, (string s, double d)) sample = (5, ("Hello", 5.5));