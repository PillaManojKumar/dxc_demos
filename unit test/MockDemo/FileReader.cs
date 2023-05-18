namespace MockDemo
{
    public class FileReader 
    {
        public string ReadText()
        {
            return File.ReadAllText("C:\\Users\\mpilla\\source\\unit test\\File1.txt");
        }
    }
}