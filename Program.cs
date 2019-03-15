// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> removeKFromList(ListNode<int> l, int k)
{
    if (l == null)
    {
        return l;
    }
    l.next = removeKFromList(l.next, k);
    if (l.value == k)
    {
        return l.next;
    }
    return l;

}

