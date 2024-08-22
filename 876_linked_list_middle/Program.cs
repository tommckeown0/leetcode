public class LinkedList{
    public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public static ListNode MiddleNode(ListNode head) {
    int listLength = 0;
    ListNode head1 = head;
    while (head != null){
        // Console.WriteLine(head.val);
        head = head.next;
        listLength++;
    }
    double listLengthDouble = listLength;
    int listMidNode = 0;
    if (listLengthDouble % 2 == 0){
        listMidNode = Convert.ToInt32((listLengthDouble / 2) + 1);
    }
    else if (listLengthDouble % 2 == 1){
        listMidNode = Convert.ToInt32(Math.Ceiling(listLengthDouble / 2));
    }
    // Console.WriteLine("listlengthdouble = " + listLengthDouble);
    // Console.WriteLine("list middle node = " + listMidNode);
    int listPosition = 0;
    while (listPosition < listMidNode - 1){
        // Console.WriteLine("head1 val = " + head1.val);
        head1 = head1.next;
        listPosition++;
    }
    return head1;
}



public static void Main(string[] args){
    //Test cases
    ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    ListNode result = MiddleNode(head);
    while (result != null){
        Console.Write(result.val + " ");
        result = result.next;
    }
    //Expected output: 3 4 5
    ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
    ListNode result2 = MiddleNode(head2);
    while (result2 != null){
        Console.Write(result2.val + " ");
        result2 = result2.next;
    }
    //Expected output: 4 5 6
}

}
