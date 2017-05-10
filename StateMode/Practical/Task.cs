using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMode.Practical
{
    public class Task
    {
        public State State { get; set; }

        public Task()
        {
            State = new PendingState();
            Console.WriteLine("初始 State：" + State.GetType().Name);
        }

        public Task(State State)
        {
            this.State = State;
            Console.WriteLine("初始 State：" + State.GetType().Name);
        }

        public void Start()
        {
            State.Start(this);
            Console.WriteLine("当前 State：" + State.GetType().Name);
        }

        public void Cancel()
        {
            State.Cancel(this);
            Console.WriteLine("当前 State：" + State.GetType().Name);
        }

    }
}
