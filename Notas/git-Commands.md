---
reviewed: false
---
#git-related

La orden principal es ` git `

### Comprobar version
` git --version`

### Configuración
` git config user.name "nombre apellidos"`
`git config user.mail "usuario@gmail.com"`

### Crear un repositorio
` git innit `

### Añadir archivos
` git add [file]`

### Estado
` git status ` : muestra los cambios que se han efectuado o faltan por efectuar
` git log ` : muestra el estado del repositorio
` git show ` : muestra el último commit con diferencias detalladas
` git diff `: muestra las diferencias entre el directorio de trabajo y el commit más reciente

###  Etiquetas
` git tag tagname ` : crear etiqueta
`` git tag -l `` : lista todas la etiquetas

### Descartar cambios
` git rm --cached filename` : el fichero ha sido subido al repositorio, pero quieres mantener una copia local

` git reset --hard` : Deshacer cambios del último commit 

` git checkout filename or branch `: para traer cambios de ficheros o [[ramas]]

### Ramas

` git branch`: para crear una rama
` git checkout `: para cambiar de rama
` git merge branch-name`: para juntar dos ramas
` git checkout -b {nombre}`: te crea una nueva rama y te apunta directamente a ella
` git log --graph`: para sacar una vista de las ramas en forma de grafo


### Bisect

`git bisect start`: para empezar la búsqueda
`git bisect bad`: para señalar que no es el que estamos buscando
`git bisect good <sha-1>`: para  marcar desde donde estamos seguros que funcionaba
`git bisect good`: para señalar que es el que estamos buscando