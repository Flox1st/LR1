using project.DZ2;



System.Console.WriteLine("\nZadanie 2:");

var Eprinter = new EuropTimePrint();
var Aprinter = new AmericanTimePrint();

ConcreteDecorator cd1 = new ConcreteDecorator("@@@@", Eprinter);
ConcreteDecorator cd2 = new ConcreteDecorator("++++", Aprinter);

cd1.Print();
cd2.Print();


