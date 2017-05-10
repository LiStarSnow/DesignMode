namespace CommadMode.Structural
{
    /// <summary>
    /// 命令的接收者
    /// <para>将命令请求传递给相应的命令对象，每个ConcreteCommand都是一个Invoker的成员</para>
    /// </summary>
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
