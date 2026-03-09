namespace BolaoUnivap
{
    internal interface IMigration
    {
        string Name { get; }

        void Up();
    }
}