using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueueTeacher
{
    public int Count { get; private set; } = 0;

    int[] q;
    int size;
    int front;
    int rear;

    public void Init(int count)
    {
        q = new int[count+1];

        size = count+1;
        rear = 0;
        front = 0;
    }

    public void Enqueue(int num)
    {
        //�����Ͱ� ���� á���� Ȯ��!
        if((rear +1)%size == front)
        {
            Debug.LogError("Enqueue Failed!! (Queue is Full)");
            return;
        }

        rear = (rear+1) % size;
        q[rear] = num;
        Count++;
        Debug.Log($"{num} Queue�� �߰� �Ϸ�. Queue �� �� : {q[front+1]} , ��⿭ �� : {Count}");
    }

    public int Dequeue()
    {
        //�����Ͱ� ������� Ȯ��!
        if(rear == front)
        {
            Debug.LogError("Dequeue Failed!! (Queue is Empty)");
            return 0;
        }
        front = (front + 1) % size;
        int ret = q[front];
        q[front] = 0;
        Count--;
        
        
        
        Debug.Log($"{ret}����, ��⿭�� : {Count}");
        return ret;
    }
}
