namespace Bolão_Univap
{
    internal interface IMigration
    {
        string Name { get; }

        void Up();
    }
}