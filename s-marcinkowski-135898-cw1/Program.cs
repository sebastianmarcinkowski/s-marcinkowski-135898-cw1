using s_marcinkowski_135898_cw1;

// var logger = new Logger(); -> Konstruktor prywatny, nie można utworzyć nowego obiektu

var logger = Logger.Instance; // Pobieramy instancję loggera

logger.Log("Hello world!");

logger = Logger.Instance; // Sprawdzam czy instacja jest taka sama

logger.Log("My name is Sebastian");

var logs = logger.GetLogMessages();

foreach (var log in logs)
{
    Console.WriteLine(log);
    
    // Program zwrócił wynik:
    // 22.12.2024 17:45:23: Hello world!
    // 22.12.2024 17:45:23: My name is Sebastian
    // Singletion jest zaimplenetowany poprawnie
}
