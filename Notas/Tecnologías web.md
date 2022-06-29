---
reviewed: true
---

# [[HTML]]

## Elementos HTML
-   Atributo
-   Contenido
-   Etiqueta de apertura y otra de cierre

```html
<span id=‘iddeesteelemento' style='color:red;' title=‘Curso de HTML'>
Curso de HTML
</span>
```


# [[ASP.NET]]
ASP.NET es un entorno para [[aplicaciones web]] desarrollado y comercializado por Microsoft. Los programadores o también diseñadores pueden utilizar este framework para construir sitios web dinámicos, [[aplicaciones web]] y servicios web.

## Introducción a las [[aplicaciones web]] [ASP.NET](http://ASP.NET)

Con el atributo `runat="server"` : dice que funciona con el [asp.net](http://asp.net), sin eso no funciona

## Code-inline vs Code-behind
![[code-in-be.png]]

### Code-behind

El código a manejar [[eventos]] se sitúa en el archivo físico separado de la página que contiene los [[controles de servidor]] y las etiquetas.

#### [[Eventos]]
La **programación dirigida por [[eventos]]** es un paradigma de programación en el que el flujo del programa está determinado por **eventos** o mensajes desde otros programas o hilos de ejecución.

Las aplicaciones desarrolladas con **programación dirigida por eventos** implementan un **bucle principal** o **main loop** donde se ejecutan las dos secciones principales de la aplicación: El selector de eventos y el manejador de eventos.


# Páginas maestras

La página maestra es la plantilla base para el resto de páginas
![[paginas-maestras.png]]

ContentPlaceHolder : Áreas que van a ser sustituidas en la parte del código en las páginas hijas de master


# Navegación entre formularios

**En HTML:** Elemento ``<a>`` y atributo href

````html
<a href=”Login.aspx”>Regístrate aquí </a>
````

**En ASPx**: control HyperLink

```html
<asp:HyperLink ID="HyperLink1" runat="server"
NavigateUrl="~/Login.aspx">Regístrate aquí</asp:HyperLink>
```

##  Formas de navegar

-   Control hipervínculo
    -   Navega a otra página
-   Método Response.Redirect
    -   Navega a otra página por medio del código. (Equivalente a navegar a través de un enlace)

## Paso de parámetros a otra página

```csharp
int valor = 22;
int valor1 = 25;
//navega hasta esa parte del código y le pasa un parámetro
Response.Redirect("Default4.aspx?par1=" + valor); 
//navega hasta esa parte del código y le pasa dos parámetros
Response.Redirect("Default4.aspx?par1=" + valor + "&par2=" + valor1);
```

Caracteres especiales: 
	-  & (para separar múltiple query strings) 
	- + (alternativa para representar un espacio) 
	- # (especifica un marcador en una página web)

URLEncode es un conversor de caracteres


![[parametros-url.png|500]]
Cuando es poca informacion usamos GET

Si son muchos datos usamos POST

Si no queremos que se enseñe la contraseña usamos POST



## Objeto Request

Podemos recibir la información con el objeto Request

```csharp
// compruebo si el parámetro 1 es vacío
if (Request.QueryString["par1"] != "") 
	Label1.Text = Request.QueryString["par1"];
```


# [[CSS]]

-   Permite definir la presentación de un documento
-   Las páginas a las que se aplica la misma hoja de estilos tendrán las mismas fuentes, colores y tamaños

Podemos incorporar el estilo de tres formas:

-   Una hoja de estilos externa, en un archivo distinto con extensión .css
-   Una hoja de estilos interna incrustada en el propio documento HTML
-   Una hoja de estilos en línea para aplicar a un elemento determinado



.dll -> dinámic library lulo
.lib -> static library


