namespace CommadMode.Structural
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
