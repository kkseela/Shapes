namespace ShapeCharacteristics.SerializationDeSerialization
{
    public abstract class FileChecker
    {
        public bool CreateFileIfNotExist(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    using (File.Create(filePath)) { }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return false;
        }

        public bool CreateDirectoryIfNotExist(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);

            // Create directory if it doesn't exist
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                return true;
            }
            return false;
        }
    }
}
