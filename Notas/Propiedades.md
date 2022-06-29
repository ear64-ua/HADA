[]()# Concepto de Propiedad

Acceder a la información (modo lectura/escritura ) de manera sencilla

`value` : valor que se asocia a la propiedad

En C# tenemos dos partes cuando definimos una propiedad:

-   Set { a = value }
-   Get { return value }

int a { set{...} get{...} }

---

```csharp
private int _e; //variable de pivote
private int edad
{
	get { return _e; }

	set { _e = value; }

}

// edad = 5 -> escritura -> set -> _e = value;
// alterar el comportamiento ...
```

```csharp
private int _e; 
private int edad
{
	get { return _e; }

	set { _e = value;
				if(_e < 0)
				_e = 0;
			 }
}
```

Ejemplo Microsoft

```csharp
using System;

class TimePeriod
{
   private double _seconds;

   public double Hours
   {
       get { return _seconds / 3600; }
       set {
          if (value < 0 || value > 24)
             throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 24.");

          _seconds = value * 3600;
       }
   }
}

class Program
{
   static void Main()
   {
       TimePeriod t = new TimePeriod();
       // The property assignment causes the 'set' accessor to be called.
       t.Hours = 24;

       // Retrieving the property causes the 'get' accessor to be called.
       Console.WriteLine($"Time in hours: {t.Hours}");
   }
}
// The example displays the following output:
//    Time in hours: 24
```