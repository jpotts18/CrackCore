namespace CrackCore
{
    public interface ILinkedList
    {
        int? First { get; }
		int? Last { get; }
        int Count { get; }
        void Prepend(int item);
        void Append(int item);
        int FindFirst(int item);
        
    }
}