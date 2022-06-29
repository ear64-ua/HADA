

# Entorno conectado

Un entorno conectado es aquel en el que los usuarios están conectados continuamente a una fuente de datos.

1.  Conectamos a una base de datos
2.  Solicitar datos
3.  Devolver datos
4.  Transmitir actualizaciones
5.  Cerrar conexión

# Entorno desconectado

Un entorno desconectado es aquel en el que los datos pueden modificarse de forma independiente y los cambios se escriben posteriormente en la base de datos.

Habrá que gestionar los conflictos en las tablas que han sido modificadas en distintos lugares y al mismo tiempo

1.  Conectar a una base de datos
2.  Solicitar los datos
3.  Devolver los datos
4.  Cerrar conexión
5.  Conectar a una base de datos
6.  Transmitir actualizaciones
7.  Cerrar la conexión

# Acceso conectado

`connection` se utiliza para establecer las conexiones

`command` sirve para ejecutar sentencias SQL

## Objeto DataReader

Es un puntero.

## Espacios de nombres

System.Data • System.Data.Common • System.Data.SqlClient →Ms SQL Server DB • System.Data.SqlTypes → contiene clases para trabajar con tipos de datos nativos de SQL Server

## Propiedad DataDirectory

Nos va a permitir que podamos en un trabajo de nuestro equipo nos la podemos mandar a un compañero y le funcione perfectamente.

En vez de:

`"AttachDbFilename= c:\\program files\\MyApp\\Mydb.mdf“`

Usamos:

`"AttachDbFilename= |DataDirectory|\\Mydb.mdf`

Para que todos tengamos por defecto la ruta del proyecto recién creado

Si todos definimos un DataDirectory, todos tendremos la misma ruta

Para aplicaciones Web, se tendrá acceso a la carpeta App_Data.

## El archivo web.config

Es un XML en el que existen unas etiquetas, <conectionStrings> en el que asociamos una cadena de conexión a ellas.

## Recuperar cadenas de conexión de archivos de configuración

using System.Configuration; string cadena; cadena = ConfigurationManager.ConnectionStrings["miconexion"].ToString (); Se recupera la cadena de conexión del archivo de con

## Ejemplo

¿Cómo se haría en el ejemplo que estamos viendo??

```csharp
while ()
{
	this.label1.Text+=dr["usuario"].ToString();
	label1.Text+=" ";
}

```

ExecuteNonQuery te devuelve el numero de elementos afectados

ExecuteReader te devuelve el conjunto de elementos