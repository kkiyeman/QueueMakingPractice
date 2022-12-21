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
        //데이터가 가득 찼는지 확인!
        if((rear +1)%size == front)
        {
            Debug.LogError("Enqueue Failed!! (Queue is Full)");
            return;
        }

        rear = (rear+1) % size;
        q[rear] = num;
        Count++;
        Debug.Log($"{num} Queue에 추가 완료. Queue 맨 앞 : {q[front+1]} , 대기열 수 : {Count}");
    }

    public int Dequeue()
    {
        //데이터가 비었는지 확인!
        if(rear == front)
        {
            Debug.LogError("Dequeue Failed!! (Queue is Empty)");
            return 0;
        }
        front = (front + 1) % size;
        int ret = q[front];
        q[front] = 0;
        Count--;
        
        
        
        Debug.Log($"{ret}추출, 대기열수 : {Count}");
        return ret;
    }
}
