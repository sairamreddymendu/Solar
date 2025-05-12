# 🌌 Solar

This C# console application retrieves data from the public [Solar System OpenData API](https://api.le-systeme-solaire.net/en/) to display information about planets and their moons. Specifically, it shows:

- The name of each planet with at least one moon
- The total number of moons
- The name and average temperature of each moon (if available)

In addition to console output, the application saves the results to a CSV file [PlanetsAndTheirAverageMoonTemperature.csv](https://github.com/sairamreddymendu/Solar/blob/master/Solar/PlanetsAndTheirAverageMoonTemperature.csv).

---

## 🛠️ How to Run

Ensure you have [.NET 7 SDK] installed.

To run the application:

```bash
dotnet restore
dotnet run

