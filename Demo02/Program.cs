


using Demo02;

List<Vehiculo> vehiculos = new List<Vehiculo>();

vehiculos.Add(new Automovil { Marca="Audi", Modelo="2024" ,PantallaTactil="China"}  );
vehiculos.Add(new Motocicleta { Marca = "Bayaje", Modelo = "2023" });
vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "2024", PantallaTactil = "China" });
vehiculos.Add(new Motocicleta { Marca = "Bayaje", Modelo = "2022" });
vehiculos.Add(new Automovil { Marca = "Audi2", Modelo = "2023", PantallaTactil = "Gringa" });
vehiculos.Add(new Motocicleta { Marca = "Bayaje3", Modelo = "2022" });
vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "2024" });
vehiculos.Add(new Motocicleta { Marca = "Bayaje3", Modelo = "2022" });
vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "2024" });
vehiculos.Add(new Motocicleta { Marca = "Bayaje4", Modelo = "2022" }); vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "2024" });
vehiculos.Add(new Motocicleta { Marca = "Bayaje", Modelo = "2021" });



foreach (var item in vehiculos)
{
    item.CalcularPrecioVenta();//Implementación en los hijos
    item.MostrarInformacion();//Implementación en el padre//Implementa al medio hermano
}
Console.Read();
