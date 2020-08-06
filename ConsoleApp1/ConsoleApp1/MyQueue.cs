using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MyQueue
    {
        List<int> stack = new List<int>();

        /** Initialize your data structure here. */
        public MyQueue() {
        
        }
    
        /** Push element x to the back of queue. */
        public void Push(int x) {
            stack.Insert(0,x);
        }
    
        /** Removes the element from in front of queue and returns that element. */
        public int Pop() {
            stack.RemoveAt(0);
            int result = stack.IndexOf(0);
            return result;
        }
    
        /** Get the front element. */
        public int Peek() {
            int result = stack.IndexOf(0);
            return result;
        }
    
        /** Returns whether the queue is empty. */
        public bool Empty() {
            if(stack.IndexOf(0) !=null){
                return true;
            }
            else{
                return false;
            }
        }
    }
}