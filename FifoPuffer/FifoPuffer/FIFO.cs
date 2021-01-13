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
        private Queue<int> _queue = new Queue<int>();

        public FIFO(int queueLength)
        {
            _queueLength = queueLength;
        }

        public void Put(int newItem)
        {
            if (_queue.Count == _queueLength)
            {
                MessageBox.Show("Queueueue Full");
            }
            else
            {
                _queue.Enqueue(newItem);
            }
        }
        public int Get()
        {
            if(_queue.Count == 0)
            {
                MessageBox.Show("Queueueue Empty");
                return 0;
            }
            else
            {
                return _queue.Dequeue();
            }
        }
        public string GetAll()
        {
            if (_queue.Count == 0)
            {
                MessageBox.Show("Queueueue Empty");
                return "";
            }
            else
            {
                string output = "";
                while (_queue.Count > 0)
                {
                    output += $"{_queue.Dequeue()}, ";
                }
                return output;
            }
        }
    }
}
