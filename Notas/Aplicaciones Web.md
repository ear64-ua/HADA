---
reviewed: false
---
# Arquitectura
## Cliente

-   El software de la parte cliente se conoce como front-end
-   Inicia la petición
-   Espera y recibe la respuesta del servidor
-   Se puede conectar a un grupo de servidores de manera simultánea
-   Suele ofrecer una interfaz gráfica al usuario

## Servidor

-   El software de la parter del servidor se conoce como back-end
-   Pasivo
-   Espera las peticiones de los clientes
-   Cuando recibe una petición, la procesa y devuelve la respuesta
-   Normalmente acepta un gran número de conexiones simultáneas de los clientes

## Ventajas y Desventajas

### Ventajas

-   Distribución de aplicaciones
-   Estandarización
-   Portabilidad
-   Escabilidad

### Desventajas

-   Congestión de tráfico de red
-   Caídas del servidor

# Aplicaciones web

## [[Sistema de control de versiones (SCV)]]
Los desarrolladores de software que trabajan en equipos están escribiendo continuamente nuevo código fuente y cambiando el que ya existe.

El código de un proyecto, una aplicación o un componente de software normalmente se organiza en una estructura de carpetas o "árbol de archivos". Un desarrollador del equipo podría estar trabajando en una nueva función mientras otro desarrollador soluciona un error no relacionado cambiando código. Cada desarrollador podría hacer sus cambios en varias partes del árbol de archivos.


Se ejecuta un entorno. Através de nuestro proyecto vamos a hacer que el main que desarrollemos acceda a otro

![[web-1.png|500]]


## [[Tecnologías web]]
Servidores web: Tomcat, IIS, Apache

Protocolo utilizado: `HTTP`
-   Permite la transferencia de información en la World Wide web
-   Sin estado
-   No orientado a conexión
-   Nivel de capa de aplicación
-   Protocolo de transferencia de hipertexto

### Cliente

-   Gestionar las peticiones y receptar el contenido
-   Interpretar documentos HTML

### [[HTML]]

[[HTML]] nos permite definir el esqueleto de la web

-   Define el formato del texto, posición, colores, tamaños
-   Algunas etiquetas: `<html>`, `<script>`, `<head>`, `<div>`, `<img>`, `<li>`, `<span>`, etc.

### [[CSS]]

Cascading Style Sheet, define el estilo gráfico de la página web

-   En la misma página o en un fichero externo
-   Mayor control de presentación
-   Menor carga

### Javascript

Es un lenguaje de programación que está embebido dentro de una página web, para crear contenido e interactividad dinámica.

## Servidor

Software que espera las peticiones de los clientes

Tecnologías:

ASP /ASP .NET , PHP , JSP , Servlets

### ASP

Active Server Pages (ASP): Lenguaje de Script, con un intérprete (no compilado)

Permite mezclar con el lenguaje html

Es un código que está en el sevidor, entonces desde el cliente nop se puede ver.

### [[ASP.NET]]

ASP. NET: plataforma para construir aplicaciones Web.

Forma parte del .NET Framework y contiene un conjunto de librerías

# Servidores web

## Internet information Server (IIS)

IIS es un servidor web

-   IIS es un conjunto de servicios de Microsoft 
	-  ISS es una plataforma web unificada que integra:
		-   el servidor web (HTTP/HTTPS),
		-   [[ASP.NET]]
		-   otros servicios como FTP, SMTP, NNTP
		-   También puede incluir PHP o Perl

### Ventajas
-   Confiable
-   Seguro
-   Velocidad

### Desventajas
-   No es multiplataforma
-   No se recomienda su uso para desplegar aplicaciones en PHP, Python, Perl o Ruby

## Apache
Apache es un servidor web HTTP de código abierto, para plataformas Unix, Microsoft Windows, Macintosh y otras.
### Ventajas
-   Buen soporte en foros
-   Sin coste
-   Multiplataforma

### Desventajas

-   No hay soporte técnico
-   No tiene interaz gráfica

# Metodología de diseño

1.  Análisis de requisitos
    
2.  Elección de las [[tecnologías web]] a usar
    
3.  Elección del gestor de base de datos
    
4.  Arquitectura de la aplicación
    
5.  Diseño de estructuras y mapa de navegación web
    
6.  Creación del contenido de las páginas
    
7.  Diseño gráfico
    
8.  Generación de scripts para controles en el cliente
    
9.  Diseño y desarrollo de páginas dinámicas
    
10.  Validación y pruebas
    
11.  Despliegue de la solución



1.  ¿Qué son las páginas con extensión .htm? ¿Es lo mismo .html que .htm?
	
	Los archivos htm están basados en lenguajes de marcas, utilizando etiquetas y códigos que el navegador.
    
2.  ¿Cuál es el lenguaje estándar para aplicar estilos de presentación a nuestras páginas web?  
	CSS
    
3.  ¿En qué lugar se ejecuta el código JavaScript?
    
    En el cliente
    
4.  ¿Es mejor utilizar PHP o ASP? ¿Por qué?
    
    Depende de cada caso: PHP- COSTE , RENDIMIENTO, MULTIPLATAFORMA
    
    ASP: SOPORTE, FLEXIBILIDAD

