var softwareManufacturers = new List<string>() { "Microsoft", "Apple", "Oracle" };
var hardwareManufacturers = new List<string>() { "Apple", "Samsung", "Intel" };
var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
foreach (var it in itCompanies) { Console.WriteLine(it); }  