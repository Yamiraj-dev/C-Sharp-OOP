namespace InheritanceMiniProject.Interfaces
{
    public interface IRental : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}