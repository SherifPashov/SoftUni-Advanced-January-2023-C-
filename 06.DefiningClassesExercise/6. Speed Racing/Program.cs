

using SpeedRacing;

int number = int.Parse(Console.ReadLine());

Dictionary<string, Car> cars = new Dictionary<string,Car>();

for (int i = 0; i < number; i++)
{
    string[] infoCar = Console.ReadLine()
        .Split();
    string model = infoCar[0];
    double fuelAmount = double.Parse(infoCar[1]);
    double fuelConsumptionFor1km = double.Parse(infoCar[2]);
    Car car = new Car
    {
        Model = model,
        FuelAmount = fuelAmount,
        FuelConsumptionPerKilometer = fuelConsumptionFor1km,
        TravelledDistance = 0,
    };

    if (!cars.ContainsKey(model))
    {
        cars.Add(model, car);
    }
}

string input;
while ((input=Console.ReadLine())!= "End")
{
    string[] info = input
        .Split()
        .Skip(1)
        .ToArray();
    string carModel = info[0];
    double amountOfkm = double.Parse(info[1]);
    Car car = cars[carModel];
    car.Drive(amountOfkm);
    
}

foreach (var car in cars.Values)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}