using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyQueueTest : MonoBehaviour
{
    MyQueue testQueue = new MyQueue();
    MyQueueTeacher teacherQueue = new MyQueueTeacher();


    void Start()
    {



        testQueue.Init(10);
        testQueue.Enqueue(1);

        testQueue.Dequeue();
        testQueue.Dequeue();

        testQueue.Enqueue(2);
        testQueue.Enqueue(3);
        testQueue.Enqueue(4);
        testQueue.Enqueue(5);
        testQueue.Enqueue(6);
        testQueue.Enqueue(7);
        testQueue.Enqueue(8);
        testQueue.Enqueue(9);
        testQueue.Enqueue(10);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);

        testQueue.Dequeue();

        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Enqueue(11);
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();
        testQueue.Dequeue();



    }


    void Update()
    {

    }

}
