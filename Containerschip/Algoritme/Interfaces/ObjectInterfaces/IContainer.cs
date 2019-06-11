namespace Algoritme.Interfaces.ObjectInterfaces
{
    public interface IContainer
    {
        int Weight { get; }
        bool Check(IStack stack);
        bool Electricity { get; }
        string ToString();

    }
}
