
using Grpc.Net.Client;
using GRPCServer; //Lite automatiskt, instans av klass i grpcServer men har ingen referens.

//DEMO 1 (Greeter)
//var input = new HelloRequest { Name = "Bob" };
//var channel = GrpcChannel.ForAddress("https://localhost:7143");
//var client = new Greeter.GreeterClient(channel);
//var reply = await client.SayHelloAsync(input);
//string replyMessage = reply.Message;
//Console.WriteLine($"Greeting: {replyMessage} ");

//TEST 2 (Customer)
var channel = GrpcChannel.ForAddress("https://localhost:7143");
var customerClient = new Customer.CustomerClient(channel);
var clientRequested = new CustomerLookupModel { UserId = 1 };

var customer = await customerClient.GetCustomerInfoAsync(clientRequested);

Console.WriteLine($" Customer: {customer.FirstName} {customer.LastName}");

Console.ReadLine();
