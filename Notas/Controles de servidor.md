# Tipos de controladores
## Text box
```html
<form id="form1" runat="server">
<div>
<p>
 Username: <asp:TextBox id="userTextBox" TextMode="SingleLine"
 Columns="30" runat="server" />
</p>
<p>
 Password: <asp:TextBox id="passwordTextBox"
 TextMode="Password" Columns="30" runat="server" />
</p>
<p>
 Comments: <asp:TextBox id="commentsTextBox"
 TextMode="MultiLine" Columns="30" Rows="10“ runat="server"/>
</p>
</div>
</form>
```


## Button

```html
<form id="form1" runat="server">
<asp:Button id="BotonEnviar" Text="Enviar" runat="server“ OnClick="WriteText" />
<asp:Label id="Label1" runat="server" />
</form>
```

```csharp
protected void WriteText(object sender, EventArgs e)
 {
 Label1.Text = "Hola mundo";
 }
```



## Image button

```html
<form id="form1" runat="server">
 <div>
 <asp:ImageButton id="BotonImagen" ImageUrl="~/garfield.gif“ runat="server“
OnClick="WriteText" />
 <asp:Label id="Label4" runat="server" />
</div>
</form>
```

```csharp
protected void WriteText(object sender, ImageClickEventArgs e)
{
 Label4.Text = "Coordenadas:" + e.X + "," + e.Y;
}
```


## Panel

```html
<form id="form1" runat="server">
<asp:Panel id="myPanel" BackColor="Beige" Width="220" runat="server">
<p>Username: <asp:TextBox id="usernameTextBox" Columns="30“ runat="server" /></p>
<p>Password: <asp:TextBox id="TextBox1“ TextMode="Password" Columns="30" runat="server" /></p>
</asp:Panel>
<asp:Button id="hideButton" Text="Hide Panel" OnClick="HidePanel“ runat="server" />
<asp:Button id="showButton" Text="Show Panel" OnClick="ShowPanel“ runat="server" />
</form>
```

```csharp
protected void HidePanel(object sender, EventArgs e)
{ myPanel.Visible = false; }
protected void ShowPanel(object sender, EventArgs e)
{ myPanel.Visible = true; }
```

==asp net puede tener varios botones asociados a eventos diferentes==

en html solo puede haber un botón



# [[Eventos]] de los controles del servidor

Desde el navegador se enviará un evento.

## Asociar el manejador al control
![[controles-3.png||500]]
![[controles-4.png|500]]

**Eventos no-Postback**: no se envían por defecto

Por ejemplo: En un formulario cuando marcamos determinadas casillas, al darle a aceptar, se ejecutan los eventos asociados a los elementos marcados
![[controles-5.png|450]]

## [[Eventos]] de página

Las páginas [ASP.NET](http://ASP.NET) provocan [[eventos]] de ciclos de vida como Init, Load, PreRender y otros. • De manera predeterminada, los eventos de página se pueden enlazar a los métodos utilizando la convención de nomenclatura Page_nombreDeEvento. • Por ejemplo, con el fin de crear un controlador para el evento Load de la página, se puede crear un método denominado Page_Load. • En tiempo de compilación, [ASP.NET](http://asp.net/) buscará los métodos que se basen en esta convención de nomenclatura y realizará el enlace automáticamente entre el evento y el método. • Se puede utilizar la convención Page_nombreDeEvento para cualquier evento expuesto por la clase Page.

## Propiedad isPostBack

Es una propiedad a nivel de formulario, podemos saber si es la primera vez que se carga la página

```cpp
protected void Page_Load(object sender, EventArgs e)
{
	if (IsPostBack) {
	Response.Write("<br>Page has been posted back.");
	}

	else { // la primera vez que se carga entra aquií
	 Response.Write("<br>Run code only on the first load");
	}
}
```