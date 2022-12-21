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
       
        Debug.Log($"Queue 사이즈를 {count}개로 맞췄습니다");
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
            Debug.Log($"{num} Queue에 추가 완료. Queue 맨 앞 : {queNums[front]} , 대기열 수 : {Count}");
        }
        else
        {
            Debug.LogWarning($"Queue가 Full 상태라 {num} 추가 실패! Queue 맨 앞 : {queNums[front]} , 대기열 수 : {Count}");
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
            
            Debug.Log($"{d}추출, 맨 앞 : {queNums[front]}, 대기열수 : {Count}");
        }
        else
        {
            Debug.LogWarning($"Queue is Empty!! 추출실패!! 대기열수 : {Count}");
            return 0;
        }
        return d;
    }

}
