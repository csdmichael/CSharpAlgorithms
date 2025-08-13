public class QueueAlgorithms {
    protected QueueNode front;
    protected QueueNode rear;

    public void Enqueue(int x) {
        if (front == null) {
            front = new QueueNode(x);
            rear = front;
        } else {
            QueueNode newNode = new QueueNode(x);
            this.rear.next = newNode;
            this.rear = newNode;
        }
    }

    public int Dequeue() {
        if (this.front == null) {
            throw new Exception("Queue is empty");
        }
        else {
            int x;
            QueueNode currFront = this.front;
            x = currFront.data;
            this.front = currFront.next;
            return x;
        }
    }
}

public class QueueNode {
    public QueueNode(int d) {
        this.data = d;
    }
    public int data {get;set;}
    public QueueNode next {get;set;}
}