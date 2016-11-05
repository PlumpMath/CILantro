namespace CILantro.UI.ConsoleUI
{
    internal class ConsoleUIConfiguration
    {
        public string SourceCodeFilePath { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(SourceCodeFilePath)) return false;

            return true;
        }
    }
}
