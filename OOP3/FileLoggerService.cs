namespace OOP3
{
    class FileLoggerService : IloggerService //aşağıda yazılı voıd fonksiyonu interface in şablonu olduğu için ona uymak zorundayız
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
