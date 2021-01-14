using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifoPuffer
{
    class FIFO
    {

        private readonly int _queueLength = 2;
        private int [] queue;
        private int front = -1, rear = -1;

        public FIFO(int queueLength)
        {
            _queueLength = queueLength;
            queue = new int [_queueLength];
        }


        public bool Put(int newItem)
        {
            if(rear == _queueLength-1){
                 return false;
            }
            else{
                if(front == -1){
                    front = 0;
                }
        
                rear = rear + 1;
                queue[rear] = newItem;
                return true;
            }

        }

        public double Get()
        {
            if(front == -1){
                return 1.5;
            }
            else{
                return queue[front];
                front = front + 1;
        
                //Only happens when the last element was dequeued
                if(front > _queueLength-1){
	                front = -1;
	                rear = -1;
                }
            }
        }

        public string GetAll()
        {
            if(rear == -1)
                return null;
            else{
                string output = "";
                int i;        
                for(i = front; i <= rear; i++)
                     output += $"{queue[i]}, ";
                return output;
            }
        }
        //https://prepinsta.com/data-structures/implementation-of-queues-using-arrays/
        //Da ich keine Queueueue benutzen durfte übernahm ich eine Array Queueue von hier

    }
}
