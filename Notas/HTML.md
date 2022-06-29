#language 
## Estructura HTML

```html
<HTML>

	 <HEAD>
	 <TITLE> Mi web! </TITLE>
	 </HEAD>

	 <BODY>
	 <H1> Hello World </H1>
	 <! Rest of page goes here. This is a comment. >
	 </BODY>

</HTML>
```

#### `<HTML>… </HTML>`

Definen la estructura del documento



#### `<HEAD> … </HEAD>`

Delimita el encabezado del Documento HTML

#### `<BODY> … </BODY>`

Delimita el cuerpo

#### `<TITLE> … </TITLE>`

Define el título del documento HTML

#### `<SCRIPT> … </SCRIPT>`

Se utiliza para incluir programas al documento. En general se tratan de Javascripts.

#### `<STYLE> … </STYLE>`

Especifica un estilo CSS para ser utilizado en el documento.

#### `<META> … </META>`

Permite especificar información de interés como: autor, fecha de publicación, descripción, palabras claves, etc.

![[html.png]]

## Listas no ordenadas

El atributo type, que permitía cambiar el tipo de marca (type=“circle”, type=“square”, type=“disc”), no forma parte de HTML5 (uso de CSS), aunque sigue siendo compatible

## Listas ordenadas

Listas ordenadas

• Para añadir un elementos a una lista utilizaremos la etiqueta `<li>...</li>`
![[html-listas.png]]


## Enlaces

`<a href="destino">Texto del enlace</a>`

## Tablas

Creación de tabla `<table> ... </table>`

-   Filas `<tr> ... </tr>`
    
    

Ahora no se usan tablas porque se usa con CSS:

## Etiquetas de organización

Son etiquetas que permiten formar bloques, que describen mejor las partes de un documento • Todas las web están formadas por: • Encabezado de página • Herramientas de navegación • Contenido • Zona anexa de elementos asociados al contenido (publicidad) • Pie de página
![[organizacion-pagina.png]]


`<header> ... </header>`

Agrupa los elementos del encabezado de la página

`<nav> ... </nav>`

Indica los elementos del menu de navegación

`<footer> ... </footer>`

Agrupa los elementos del pie de página

`<aside> ... </aside>`

Indica que se tratan de elementos anexos al contenido

`<section> ... </section>`

Indica que una parte del contenido de la página se refiere a un tema en concreto

`<article> ... </article>` Define un contenido del documento que posee una identidad independiente dentro de la página (artículo de un blog, un post en un foro, o un product en la web de un comercio)

`<figure> ... </figure>` Permite incorporar una sección de imagen.

`<figcaption> ... </figcaption>` Contiene el texto explicativo de una imagen asociada

## Formularios

`<form> ... </form>`

`Place holder` es una ayuda para el tipo del campo

`Required` si es un dato que debe ser rellenado

5 elementos enteros

## Lista desplegable

`<select> ... </select>`

Indica el uso de una lista desplegable

`<option> ... </option>`

Forma los elementos de la lista
![[lista-desplegable.png|490]]
![[lista-desplegable-ejemplo.png]]

## Botones de selección única

`<input type="radio">`

![[radio-button-ejemplo.png]]


## Checkbox

`<input type="checkbox">
![[check-box-ejemplo.png]]