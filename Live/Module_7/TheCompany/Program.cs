namespace TheCompany;

internal class Program
{
    static void Main(string[] args)
    {
        ACME factory = new ACME();
        Eric eric = new Eric();
        Lennard ln = new Lennard();
        Anshul ash = new Anshul();
        Bokito bok =  new Bokito();
        CodeOMatic com = new CodeOMatic();

        factory.Hire(ash);
        factory.Hire(eric);
        factory.Hire(ln);
        factory.Hire(bok);
        factory.Hire(com);

        factory.BlowWhistle();

        AnotherCompany(ln);
    }

    static void AnotherCompany(IContract2 contract)
    {
        contract.DoWork();
    }
}