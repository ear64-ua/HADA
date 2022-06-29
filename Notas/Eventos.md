---
reviewed: false
---

# Eventos

Un evento puede estar presente por ejemplo cuando tras una cantidad de gasolina en tu coche, el sistema te indica que debes repostar gasolina.

## Esqueleto

-   Al principio de la misma llevamos a cabo una iniciación de todo el sistema de eventos.
-   Se definen todos los eventos que pueden ocurrir.
-   Se prepara el generador o generadores de estos eventos.
-   Se indica qué código se ejecutará en respuesta a un evento producido -ejecución diferida de código-.
-   Se espera a que se vayan produciendo los eventos.
-   Una vez producidos son detectados por el “dispatcher” o planificador de eventos, el cual se encarga de invocar el código que previamente hemos dicho que debía ejecutarse.

![[eventos-1.png|500]]

## Delegados

Puedo usarlos para ejecución diferida de código y no sólo en la programación dirigida a eventos. no se usan en la programación secuencial

Delegado es un tipo de dato que representa una referencia a un método.

Algo parecido a un puntero.

```csharp

public delegate int PerformCalculation(int x, int y);
```

```csharp
delegate Persona menor (Persona p1, Persona p2);
class Persona {
 …
 //métodos que serán parámetros de una función
 public static Persona nombreMenor (Persona p1, Persona p2){..}
 public static Persona edadMenor (Persona p1, Persona p2) {..}
 public static void muestraPrecede (Persona p1, Persona p2,
 menor cf) {

	 Person p = cf(p1, p2);
	 if (p != null) {
	 Console.WriteLine ("{0} with age {1}.", p.name, p.age);
	 }
 }
 // DATOS // PROPIEDADES C#
 public string nombre {get; set;}
 public int edad {get; set;}
}

public static void Main () {
 Persona juan = new Persona ("Juan", 20);
 Persona andres = new Persona ("Andres", 30);
 Persona.muestraPrecede (juan, andres,
 Persona.edadMenor );
 Persona.muestraPrecede (juan, andres,
 Persona.nombreMenor );
}
```


# Procedimiento para controlar varios eventos mediante las [[propiedades]] de evento
Para poder utilizar [[propiedades]] de evento, hay que definirlas en la clase que provoca los eventos y, a continuación, establecer los delegados de las propiedades de evento en las clases que controlan los eventos. Para implementar varias [[propiedades]] de evento en una clase, la clase debe almacenar y mantener internamente el delegado definido para cada evento. Para cada evento similar a campo, se genera un tipo de referencia de campo de respaldo correspondiente. Esto puede provocar asignaciones innecesarias cuando aumenta el número de eventos.


## Handler

Un manejador `handler (es un delegado)` es el código que queremos ejecutar al producirse un evento.

Puedo conectar a un evento n manejadores

Pueden pasar parámetros a los métodos manejadores y no se lanzan cuando se definen.

En la programación dirigida por enventos en C# no hay que definir uno, podemos usar un eventhandler.

La conexión entre el evento y los manejadores puede hacerse en el constructor de la clase. (No se hace después de invocar al evento)

### Ejemplo

```csharp
public class VideoEncoder
{
	public void EncodeVideo(Video video)
	{
	//encode logic
		_mailService.send(new Mail())
	}
}
```

```csharp
public class VideoEncoder
{
	public void EncodeVideo(Video video)
	{
		//encode logic
		OnVideoEncoded();
	}
}
```

-   ¿ Cómo va a saber enviar el evento?
    
    Concepto del `delegado`
    

Definir el delegado:

```csharp
public delegate void VideoEncodedEventHandler(object sender, EventArgs args)
```

Definir el evento basándonos en el delegado

```csharp
public event VideoEncodedEventHandler videoEncoded;
```

Lanzar el evento

```csharp
videoEncoded(this,EventArgs.Empty)
```

Cancelar la subsricpión del evento

```csharp
ob.evento -= manejador
```

---

```csharp
public class VideoEncoder{

public delegate void VideoEncodedEventHandler(object sender, EventArgs args);

public event VideoEncodedEventHandler videoEncoded;
	public void EncodeVideo(Video video) {//encode logic
		OnVideoEncoded();
	}
}

protected virtual void OnVideoEncoded() //notify subscribers
{if videoEncoded!= null //if we have any subscriber
videoEncoded(this, EventArgs.Empty);
}
```

```csharp
public class MailService
{
public void OnVideoEncoded(object source,
EventArgs e)
{
Console.WriteLine(“MailService: enviando email”);
}
```

```csharp
class Program{
	static void Main(string[] args){
		Video video= new Video();
		VideoEncoder v=new VideoEncoder(); //publisher
		MailService ms=new MailService(); //subscriber
		v.videoEncoded+=ms.OnVideoEncoded; // vincular emisor y receptor
		//pointer to that method, we do the subscription
		v.Encode(video);
```
