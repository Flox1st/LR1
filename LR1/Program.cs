using project.DZ1;

System.Console.WriteLine("Zadanie 1:");

Rat a = new Rat(30, 7);
//Rat a = new Rat(30, 0);
System.Console.WriteLine(a.ToString());
System.Console.WriteLine(a.numinator+"\n");


a = new Rat(0, 5);
System.Console.WriteLine(a.ToString());
System.Console.WriteLine(a.numinator);
System.Console.WriteLine(a.denominator + "\n");


a = new Rat(1, 2);
a = a * new Rat(2, 3);
System.Console.WriteLine(a.ToString() + "\n");


a = new Rat(-2, -7);
System.Console.WriteLine(a.ToString());



