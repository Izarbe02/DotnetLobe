
using Models;

var plato = new PlatoPrincipal("Plato combinado", 12.50, "Pollo, patatas, tomate");
plato.MostrarDetalles();

var bebida = new Bebida("Limonada", 1.50, false);
bebida.MostrarDetalles();

var postre = new Postre("Tiramisú", 7.00, 800);
postre.MostrarDetalles();

var pedido = new Pedido();
pedido.AnadirProductos(plato);
pedido.AnadirProductos(bebida);
pedido.AnadirProductos(postre);

//pedido.MostrarPedido();

var total = pedido.CalcularTotal();
Console.WriteLine($"Total pedido: {total}");

var descuento = 0.15;
pedido.Descuento = descuento;
var totalConDescuento = pedido.CalcularTotal();
Console.WriteLine($"Total pedido con descuento ({descuento*100}%): {totalConDescuento:C}");

var combo = new Combo(plato,bebida,postre,descuento);
combo.MostrarDetalles();


pedido.AnadirProductos(combo,3);
pedido.MostrarPedido();
var totalConCantidad = pedido.CalcularTotal();
Console.WriteLine($"Total pedido: {totalConCantidad}");

var rutaFicheroPedido = "pedido.txt";
pedido.GuardarPedido(rutaFicheroPedido);

var pedidoCargado = new Pedido();
pedidoCargado.CargarPedido(rutaFicheroPedido);
pedidoCargado.MostrarPedido();
pedido.MostrarPedido();




var menuApp = new MenuApp();
menuApp.MostrarMenu();