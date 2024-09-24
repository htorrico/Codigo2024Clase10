using Demo03;

List<Cuenta> cuentas = new List<Cuenta>();

// Crear una cuenta corriente y una cuenta de ahorro
CuentaCorriente cuentaCorriente = new CuentaCorriente
{
    NumeroCuenta = "123456789",
    Titular = "Juan Pérez",
    Saldo = 1000m
};
CuentaAhorro cuentaAhorro = new CuentaAhorro
{

    NumeroCuenta = "987654321",
    Titular = "María López",
    Saldo = 500m
};


// Agregar cuentas a la lista
cuentas.Add(cuentaCorriente);
cuentas.Add(cuentaAhorro);



// Realizar operaciones
cuentaCorriente.Depositar(200m);
cuentaCorriente.Retirar(300m);

cuentaAhorro.Depositar(150m);
cuentaAhorro.Retirar(100m);


//Estos dos son el mismo objeto apuntando a la misma dirección en memoria
//cuentas[0]
//cuentaCorriente


// Mostrar detalles de todas las cuentas
Console.WriteLine("\nDetalles de las cuentas:");
foreach (var cuenta in cuentas)
{
    cuenta.MostrarDetalles();
}
Console.Read();