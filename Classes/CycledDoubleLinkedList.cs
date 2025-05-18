namespace trees.Classes;

internal class CycledDoubleLinkedList()
{
    private readonly ListNode head = new();

    public void InsertAfterLast(int c)
    {
        ListNode ins = new(c, head, head.prev);
        head.prev.next = ins;
        head.prev = ins;
    }

    public void FillListBox(ListBox l)
    {
        ListNode p = head.next;
        while (p != head)
        {
            l.Items.Add(p.info.ToString());
            p = p.next;
        }
    }
}
