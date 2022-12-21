using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyQueue
{



    //protected int count = 0;
    private int front { get; set; } = 0;
    private int rear { get; set; } = 0;
    private int size { get; set; } = 0;
   

    public int Count {get; private set;} = 0;

    public int[] queNums;





    public void Init(int count)
    {
        queNums = new int[count];
        size = count;
       
        Debug.Log($"Queue ����� {count}���� ������ϴ�");
    }

    public void Enqueue(int num)
    {
        if (Count < size)
        {
            queNums[rear] = num;
            rear = ++rear % size;
            Count++;
            if (rear == front)
                Count = size;
            Debug.Log($"{num} Queue�� �߰� �Ϸ�. Queue �� �� : {queNums[front]} , ��⿭ �� : {Count}");
        }
        else
        {
            Debug.LogWarning($"Queue�� Full ���¶� {num} �߰� ����! Queue �� �� : {queNums[front]} , ��⿭ �� : {Count}");
        }
        

    }



    public int Dequeue()
    {
        int d = 0;
        if (Count > 0)
        {
            d = queNums[front];
            queNums[front] = 0;
            front = ++front % size;
            Count--;
            if(rear == front)
                Count = 0;
            
            Debug.Log($"{d}����, �� �� : {queNums[front]}, ��⿭�� : {Count}");
        }
        else
        {
            Debug.LogWarning($"Queue is Empty!! �������!! ��⿭�� : {Count}");
            return 0;
        }
        return d;
    }

}
