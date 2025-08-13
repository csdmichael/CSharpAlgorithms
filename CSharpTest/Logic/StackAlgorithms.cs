public class StackAlgorithms {
    protected StackNode top {get;set;}
    public int count = 0;
    public void Push(int x) {
        StackNode newTop = new StackNode();
        newTop.value = x;
        newTop.next = top;
        top = newTop;
        count++;
    }

    public int Pop() {
        if (top == null) {
            throw new Exception("Stack is empty");
        } else {
            int x = top.value;
            top = top.next;
            count--;
            return x;
        }
    }
}

public class StackNode {
    public int value {get;set;}
    public StackNode next {get;set;}
}