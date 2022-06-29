#git-related 
# Sistema de control de versiones (SCV)

Usado para almacenar distintas versiones del mismo archivo.

La mejor manera de tener un control de versiones y un historial es mediante [[git]]

## SVC Centralizado
+ Repositorio único
- No permite trabajar sin conexión
![[SCV Centralizado.png]]

## SVC Distribuido

- Cada usuario tiene su repositorio local 
- Puedes trabajar sin conexión
![[SCV Distribuido.png]]

### Definiciones
- **Repositorio**: Es la copia maestra donde se guardan todas las versiones de archivos de un proyecto.

- **Copia de trabajo**: La copia de los ficheros del proyecto que podemos modificar

- **Check Out / Clone**: La acción empleada para obtener una copia de trabajo desde el repositorio.

- **Check In / Commit**: La acción empleada para llevar los cambios hechos en la copia de trabajo a la copia local del repositorio. 

- **Push**: La acción que traslada los contenidos de la copia local del repositorio de un programador a la copia maestra.


Para el manejo de control de versiones se suele usar [[git]]


Si dos versiones entran en conflicto (see [[Conflictos y flujo de trabajo]]), los mismos clientes son los que deben decidir cuál versión es válida y subirlo con un commit/push. Esto ocurre por ejemplo cuando dos personas realizan cambios en una misma zona, y el SCV central no sabe con cuál de ellas quedarse.

