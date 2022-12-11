namespace HW_2_1
{

    internal class Program
    {
        private static void Main()
        {
            Starter.Run();

            Logger.Get().LogLevel = LogStatus.Info;
            Logger.Get().Output();

        }
    }
}