#language 
## Hoja de estilo externa

• Se emplazan todas las reglas de estilo en una única hoja de estilos externa • Se enlaza esta hoja de estilos externa con todas las páginas que vayan a tener la misma apariencia • Para hacer una referencia a una hoja de estilos externa en una web, hay que introducir en el elemento HEAD, la siguiente sentencia: `<link rel=“Stylesheet" type="text/css" href=“~/hoja.css" />`

## Hoja de estilo interna

• Hoja de estilo incrustada dentro de un documento. • Se utiliza las etiqueta <style>, dentro del elemento HEAD • Se debe reescribir en cada página (lo cual es un problema) • Se definen las reglas de estilo entre las etiquetas: `<style type="text/css"> a { background-color: #ff9; color: #00f; } </style>`

## Hoja de estilo en línea

• Permiten asignar un estilo a un elemento determinado • Para ello hay que utilizar el atributo style dentro del elemento al que se quiere aplicar el estilo

`<a href="/" style="background-color: #ff9; color: #00f;"> Home</a>`

`<h1 style=“color:blue;margin-left:60 px;”> Estilo en línea </h1>`

## Noción de cascada

En caso de que existan varias definiciones de estilo, interviene la noción de cascada

## Selector de tipo de elemento
![[css-1.png|500]]
![[css-2.png|500]]
![[css-3.png|500]]
![[css-4.png|500]]
## Propiedades de estilo

-   Font: Tipo de fuente, tamaño, color, negrita...
-   Background: color de fondo, imagen de fondo...
-   Block: espacio entre párrafos, líneas, palabras...
-   Box: personalizar tablas, colores, bordes...
-   Border: dibuja bordes alrededor de diferentes elementos

## CssClass

Los controladores de ASP.NET ([[Controles de servidor]]) , nos van a pedir un css class.![[css-5.png]]