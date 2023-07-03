namespace template_method_pattern.template;
public class TransferMoneyTask : Task
{
    protected override void DoExecute()
    {
        Console.WriteLine("Transfer Money");
    }
}