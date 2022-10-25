namespace TestesUnitarios
{
    public class FileClass
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)){
                throw new ArgumentNullException("FileName");
            }
            return File.Exists(fileName);
        }
    }
}
