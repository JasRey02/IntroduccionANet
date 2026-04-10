ILogger consoleLogger = new ConsoleLogger();
consoleLogger.Log("Este es un mensaje de log en la consola");

ILogger filelogger = new FileLogger();
filelogger.Log("Este es un mensaje de log en un archivo");

ILogger hibridoLogger = new HibridoLogger();
hibridoLogger.Log("Muestro un mensaje en consola y se crea el archivo logHibrido.txt");