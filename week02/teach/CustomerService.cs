/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Initialize the queue to 3 customer max
        // Expected Result: after the 3rd queue the output should say Maximum Number of Customers in Queue.
        Console.WriteLine("Test 1");

        var customer = new CustomerService(3);
        customer.AddNewCustomer();
        customer.AddNewCustomer();
        customer.AddNewCustomer();
        customer.AddNewCustomer();



        // Defect(s) Found: The if statement on the addCustomer method was a bit off when the user initializes there would always be a +1 size on the queue since the condition stated queue.Count > _maxSize, changed it to >= so it would initialized to what the user wanted it to be

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Serving a customer, removing a customer from the front of the queue
        // Expected Result: [size=2 max_size=3 => a (a)  : a, a (a)  : a]
        Console.WriteLine("Test 2");

        var user2 = new CustomerService(3);
        user2.AddNewCustomer();
        user2.AddNewCustomer();
        user2.AddNewCustomer();

        // Remove a customer
        user2.ServeCustomer();
        // Display the remaining customers
        Console.WriteLine(user2);


        // Defect(s) Found: The ServeCustomer method was a bit off since the it was removing the first item on the queue first then getting a the 1st item it would result to the user getting the 2nd customer, changed the order of the code getting the element first then removing it

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}