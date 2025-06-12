
namespace DesignPatterns
{
    // ============================================================================
    // DEMONSTRATION CLASS
    // ============================================================================
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DESIGN PATTERNS DEMONSTRATION ===\n");

            // Demonstrate all patterns
            DemonstrateBehavioralPatterns();
            Console.WriteLine();
            DemonstrateStructuralPatterns();
        }

        private static void DemonstrateBehavioralPatterns()
        {
            Console.WriteLine("BEHAVIORAL PATTERNS\n");

            // Chain of Responsibility
            Console.WriteLine("1. Chain of Responsibility:");
            var handler = new BehavioralPatterns.ChainOfResponsibility.InvoiceHandler();
            handler.SetNext(new BehavioralPatterns.ChainOfResponsibility.ReceiptHandler())
                   .SetNext(new BehavioralPatterns.ChainOfResponsibility.BillHandler());
            handler.Handle("Invoice");
            handler.Handle("Unknown");
            Console.WriteLine();

            // Command
            Console.WriteLine("2. Command:");
            var editor = new BehavioralPatterns.Command.TextEditor();
            var commandManager = new BehavioralPatterns.Command.CommandManager();
            commandManager.ExecuteCommand(new BehavioralPatterns.Command.WriteTextCommand(editor, "Hello, "));
            commandManager.ExecuteCommand(new BehavioralPatterns.Command.WriteTextCommand(editor, "world!"));
            commandManager.Undo();
            commandManager.Undo();
            commandManager.Redo();
            editor.Display();
            Console.WriteLine();

            // Interpreter
            Console.WriteLine("3. Interpreter:");
            var expression = new BehavioralPatterns.Interpreter.AddExpression(
                new BehavioralPatterns.Interpreter.NumberExpression(5),
                new BehavioralPatterns.Interpreter.SubtractExpression(
                    new BehavioralPatterns.Interpreter.NumberExpression(10), 
                    new BehavioralPatterns.Interpreter.NumberExpression(3))
            );
            Console.WriteLine(expression.Interpret());
            Console.WriteLine();

            // Iterator
            Console.WriteLine("4. Iterator:");
            var playlist = new BehavioralPatterns.Iterator.Playlist();
            playlist.Add("Song 1");
            playlist.Add("Song 2");
            playlist.Add("Song 3");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();

            // Mediator
            Console.WriteLine("5. Mediator:");
            var mediator = new BehavioralPatterns.Mediator.ChatMediator();
            var user1 = new BehavioralPatterns.Mediator.User("Alice", mediator);
            var user2 = new BehavioralPatterns.Mediator.User("Bob", mediator);
            user1.SendMessage("Hello, Bob!");
            user2.SendMessage("Hi, Alice!");
            Console.WriteLine();

            // Memento
            Console.WriteLine("6. Memento:");
            var player = new BehavioralPatterns.Memento.Player();
            player.Position = 5;
            player.Health = 100;
            var caretaker = new BehavioralPatterns.Memento.Caretaker();
            caretaker.Save(player.SaveState());
            player.Position = 10;
            caretaker.Restore(player);
            Console.WriteLine(player.Position);
            Console.WriteLine();

            // Observer
            Console.WriteLine("7. Observer:");
            var order = new BehavioralPatterns.Observer.Order();
            order.Attach(new BehavioralPatterns.Observer.EmailNotifier());
            order.Attach(new BehavioralPatterns.Observer.SmsNotifier());
            order.UpdateStatus("Shipped");
            Console.WriteLine();

            // State
            Console.WriteLine("8. State:");
            var vendingMachine = new BehavioralPatterns.State.VendingMachine();
            vendingMachine.InsertCoin();
            vendingMachine.SelectProduct();
            vendingMachine.DispenseProduct();
            Console.WriteLine();

            // Strategy
            Console.WriteLine("9. Strategy:");
            var calculator = new BehavioralPatterns.Strategy.ShippingCalculator(
                new BehavioralPatterns.Strategy.EconomyShipping());
            Console.WriteLine(calculator.Calculate(100));
            calculator.SetStrategy(new BehavioralPatterns.Strategy.ExpressShipping());
            Console.WriteLine(calculator.Calculate(100));
            Console.WriteLine();

            // Template Method
            Console.WriteLine("10. Template Method:");
            var pdfReport = new BehavioralPatterns.TemplateMethod.PdfReportGenerator();
            pdfReport.GenerateReport();
            var excelReport = new BehavioralPatterns.TemplateMethod.ExcelReportGenerator();
            excelReport.GenerateReport();
            Console.WriteLine();

            // Visitor
            Console.WriteLine("11. Visitor:");
            var visitor = new BehavioralPatterns.Visitor.ValidationVisitor();
            var elementA = new BehavioralPatterns.Visitor.ElementA();
            elementA.Accept(visitor);
            Console.WriteLine();
        }

        private static void DemonstrateStructuralPatterns()
        {
            Console.WriteLine("STRUCTURAL PATTERNS\n");

            // Adapter
            Console.WriteLine("1. Adapter:");
            var monitor = new StructuralPatterns.Adapter.TemperatureMonitor();
            var sensorA = new StructuralPatterns.Adapter.SensorAAdapter(new StructuralPatterns.Adapter.SensorA());
            var sensorB = new StructuralPatterns.Adapter.SensorBAdapter(new StructuralPatterns.Adapter.SensorB());
            var sensorC = new StructuralPatterns.Adapter.SensorCAdapter(new StructuralPatterns.Adapter.SensorC());
            monitor.DisplayTemperature(sensorA);
            monitor.DisplayTemperature(sensorB);
            monitor.DisplayTemperature(sensorC);
            Console.WriteLine();

            // Bridge
            Console.WriteLine("2. Bridge:");
            var redCircle = new StructuralPatterns.Bridge.Circle(new StructuralPatterns.Bridge.RedColor());
            var blueSquare = new StructuralPatterns.Bridge.Square(new StructuralPatterns.Bridge.BlueColor());
            var greenTriangle = new StructuralPatterns.Bridge.Triangle(new StructuralPatterns.Bridge.GreenColor());
            redCircle.Draw();
            blueSquare.Draw();
            greenTriangle.Draw();
            Console.WriteLine();

            // Composite
            Console.WriteLine("3. Composite:");
            var mainMenu = new StructuralPatterns.Composite.Menu("Main Menu");
            var appetizerMenu = new StructuralPatterns.Composite.Menu("Appetizers");
            var mainCourseMenu = new StructuralPatterns.Composite.Menu("Main Courses");
            
            appetizerMenu.Add(new StructuralPatterns.Composite.MenuItem("Caesar Salad", 8.99m));
            appetizerMenu.Add(new StructuralPatterns.Composite.MenuItem("Bruschetta", 6.99m));
            
            mainCourseMenu.Add(new StructuralPatterns.Composite.MenuItem("Grilled Salmon", 18.99m));
            mainCourseMenu.Add(new StructuralPatterns.Composite.MenuItem("Beef Steak", 22.99m));
            
            mainMenu.Add(appetizerMenu);
            mainMenu.Add(mainCourseMenu);
            mainMenu.Add(new StructuralPatterns.Composite.MenuItem("Daily Special", 15.99m));
            
            mainMenu.Display();
            Console.WriteLine();

            // Decorator
            Console.WriteLine("4. Decorator:");
            var notification = new StructuralPatterns.Decorator.BaseNotification();
            var emailNotification = new StructuralPatterns.Decorator.EmailDecorator(notification);
            var smsEmailNotification = new StructuralPatterns.Decorator.SMSDecorator(emailNotification);
            var fullNotification = new StructuralPatterns.Decorator.PushDecorator(smsEmailNotification);
            fullNotification.Send("Your order has been shipped!");
            Console.WriteLine();

            // Facade
            Console.WriteLine("5. Facade:");
            var dvdPlayer = new StructuralPatterns.Facade.DvdPlayer();
            var projector = new StructuralPatterns.Facade.Projector();
            var lights = new StructuralPatterns.Facade.Lights();
            var soundSystem = new StructuralPatterns.Facade.SoundSystem();
            
            var homeTheater = new StructuralPatterns.Facade.HomeTheaterFacade(
                dvdPlayer, projector, lights, soundSystem);
            
            homeTheater.PlayMovie("Inception");
            Console.WriteLine();
            homeTheater.EndMovie();
            Console.WriteLine();

            // Flyweight
            Console.WriteLine("6. Flyweight:");
            var forest = new StructuralPatterns.Flyweight.Forest();
            
            // Plant many trees
            for (int i = 0; i < 10; i++)
            {
                forest.PlantTree(i * 10, i * 5, 2.5, "Oak", "Green", "Rough");
                forest.PlantTree(i * 12, i * 8, 3.0, "Pine", "Dark Green", "Smooth");
            }
            
            Console.WriteLine($"Forest has {forest.GetTreeCount()} trees");
            Console.WriteLine($"TreeTypes created: {StructuralPatterns.Flyweight.TreeFactory.GetCreatedTreeTypesCount()}");
            Console.WriteLine("First few trees:");
            // Show just first few to avoid too much output
            var limitedForest = new StructuralPatterns.Flyweight.Forest();
            limitedForest.PlantTree(0, 0, 2.5, "Oak", "Green", "Rough");
            limitedForest.PlantTree(10, 5, 3.0, "Pine", "Dark Green", "Smooth");
            limitedForest.Render();
            Console.WriteLine();

            // Proxy
            Console.WriteLine("7. Proxy:");
            var image1 = new StructuralPatterns.Proxy.ProxyImage("high_res_photo1.jpg");
            var image2 = new StructuralPatterns.Proxy.ProxyImage("high_res_photo2.jpg");
            
            Console.WriteLine("Images created, but not loaded yet.");
            Console.WriteLine("Displaying image1:");
            image1.Display();
            Console.WriteLine("Displaying image1 again (should not reload):");
            image1.Display();
            Console.WriteLine("Displaying image2:");
            image2.Display();
        }
    }
}