using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode.Practical
{
    public class RunningState : State
    {
        public override void Cancel(Task task)
        {
            task.State = new CancelledState();
        }

        public override void Start(Task task)
        {
            task.State = new FinishedState();
        }
    }
}
