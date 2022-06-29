---
reviewed: false
---
#git-related 
## Ejemplos Conflictos [[git-Commands]]
<div style="border: 1px solid orange; padding : 25px"> 
<ul>
<li>	1.  Tenemos un archivo compra.txten master</li>
<li>	2.  Desde el último commit de master, crea una nueva rama rama1 </li>	
<li>	3.  En rama1, añade un elemento a la lista en compra.txt, confirma los cambios </li>	
<li>	4.  Fusiona master y rama1 </li>	
</ul>

<p>git commit -am “commit in..”</p>

<p>git branch rama1 HEAD</p>

<p>git checkout rama1</p>

<p>git commit -am “add item to compra.txt”</p>

<p>git checkout master</p>

<p>git merge rama1</p></div>

<div style="border: 1px solid orange; padding : 25px"> 
<ul>
<li>	1.  Ahora tenemos dos archivos (file1,file2) en master</li>
<li>	2. En master, modificamos el archivo file1, confirma los cambios</li>	
<li>	3.  Desde el penúltimo commit de Master, crea una nueva rama rama2 </li>	
<li>	4.  En rama2 modificamos el archivo file2, confirma los cambios </li>	
</ul>

<p>git commit -am “add file1 and file2”</p>

<p>git commit -am “modify file1”</p>

<p>git branch rama2 HEAD~1</p>

<p>git checkout rama2</p>

<p>git commit -am “modify file2”</p>
<p>git checkout master</p>

<p>git merge rama2</p></div>


# Flujo de trabajo en [[Git]]

Dos protocolos de trabajo

Centralized Workflow (se trabaja en una sola rama, se crean muchos conflictos)

Gitflow Workflow (más eficiente, se trata en diferentes [[ramas]] con diferentes fases)

## Gitflow Workflow

-   Crea una rama (creamos una nueva rama para no afectar a la rama master)
-   Añadir commits (registrar progreso por cada modificación, hacerlo con lógica)
-   Abir una Pull Request (es una especie de “oye yo que he terminado mi parte, quiero que mis compañeros vean mis commits y haganm comentarios sobre ellos” )
-   Discute y revisa tu código (El encargado de revisar puede hacer comentarios o preguntas)
-   Despliegue (si la rama tiene problemas en producción, se puede volver atrás)
-   Combinar (una vez está todo bien, lo que hacemos es combinar a la rama master)
