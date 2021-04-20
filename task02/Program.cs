namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            AbstractHandler abstractHandler = new XmlHandler();
            abstractHandler.Open();
            abstractHandler.Create();
            abstractHandler.Change();
            abstractHandler.Save();
            abstractHandler = new TxtHandler();
            abstractHandler.Open();
            abstractHandler.Create();
            abstractHandler.Change();
            abstractHandler.Save();
            abstractHandler = new DocHandler();
            abstractHandler.Open();
            abstractHandler.Create();
            abstractHandler.Change();
            abstractHandler.Save();
        }
    }
}
