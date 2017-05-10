using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode.Practical
{
    public class PendingState : State
    {
        public override void Cancel(Task task)
        {
            throw new NotImplementedException();
        }

        public override void Start(Task task)
        {
            task.State = new RunningState();
        }
    }
}
