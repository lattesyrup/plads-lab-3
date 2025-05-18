namespace trees.Classes;
#nullable disable

internal class ListNode
{
    public readonly int info;
    public ListNode prev;
    public ListNode next;

    public ListNode(int info, ListNode next, ListNode prev)
    {
        this.info = info;
        this.next = next;
        this.prev = prev;
    }

    // elemental circle creating
    public ListNode()
    {
        next = this;
        prev = this;
    }
}
