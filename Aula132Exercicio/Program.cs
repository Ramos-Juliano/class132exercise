using CLass132Exercicio.Entities;
using Class132.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("E-mail: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.WriteLine("How many items to this order? ");
int amount = int.Parse(Console.ReadLine());

for(int i = 1; i <= amount; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(quantity, productPrice, product);
    order.AddItem(orderItem);

}
Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order.ToString());





