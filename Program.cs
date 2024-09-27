Retangulo r1 = new Retangulo();
Retangulo r2 = new Retangulo(5);
Retangulo r3 = new Retangulo(4, 6);

Console.WriteLine($"A area do retangulo R1 = {r1.CalcularArea()}");
Console.WriteLine($"O perimetro do retangulo  R1 = {r1.CalcularAreaPerimetro()}");

Console.WriteLine($"A area do retangulo R2 = {r2.CalcularArea()}");
Console.WriteLine($"O perimetro do retangulo  R2 = {r2.CalcularAreaPerimetro()}");

Console.WriteLine($"A area do retangulo R3 = {r3.CalcularArea()}");
Console.WriteLine($"O perimetro do retangulo  R3 = {r3.CalcularAreaPerimetro()}");

r3.Redimensionar(2);
Console.WriteLine($"A area do retangulo R2 = {r2.CalcularArea()}");
Console.WriteLine($"O perimetro do retangulo  R2 = {r2.CalcularAreaPerimetro()}");

r2.Redimensionar(10,15);
Console.WriteLine($"A area do retangulo R3 = {r3.CalcularArea()}");
Console.WriteLine($"O perimetro do retangulo  R3 = {r3.CalcularAreaPerimetro()}");


