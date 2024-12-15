namespace _04InterfaceSegregationPrincipleISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Printer();
            IFax fax = new Fax();
            IScanner scanner = new Scanner();
            IMultiFunctionDevice multiFunctionDevice = new MultiFunctionalDevice();

            printer.Print();
            fax.SendFax();
            scanner.Scan();
            multiFunctionDevice.Print();
            multiFunctionDevice.SendFax();
            multiFunctionDevice.Scan();


            IBasicPlayer simplePlayer = new SimplePlayer();
            IAdvancedPlayer advancedPlayer = new AdvancedPlayer();

            simplePlayer.Play();
            simplePlayer.Pause();

            advancedPlayer.Play();
            advancedPlayer.Pause();
            advancedPlayer.Next();
            advancedPlayer.Previous();
            advancedPlayer.Shuffle();
        }
    }
}
