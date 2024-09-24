


using CodigoClase10;


//Inputs
CuentaAhorro cuentaAhorro = new CuentaAhorro
{
    NumeroCuenta = "xyz",
    Saldo=0,
};

TarjetaCredito tarjetaCredito = new TarjetaCredito
{
    NumeroCuenta = "abc",
    Saldo=1500
};

CuentaMancomunada cuentaMancomunada = new CuentaMancomunada
{
    NumeroCuenta = "123",
    Saldo = 3000
};

//#region FormaTradicional
////Procesos
//cuentaAhorro.Depositar(500);
//tarjetaCredito.Depositar(500);
//cuentaMancomunada.Depositar(500);


////Outputs

//cuentaAhorro.MostrarInformacion();
//tarjetaCredito.MostrarInformacion();
//cuentaMancomunada.MostrarInformacion();
//#endregion



List<Cuenta> cuentas = new List<Cuenta>();
cuentas.Add(cuentaAhorro);
cuentas.Add(cuentaMancomunada);
cuentas.Add(tarjetaCredito);



//Procesos
foreach (var item in cuentas)
{
    item.Depositar(500);
}


//Output
foreach (var item in cuentas)
{
    item.MostrarInformacion();
}



Console.Read();



