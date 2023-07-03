namespace template_method_pattern.template;
public class GenerateReportTask
{
    private readonly AuditTrail _auditTrail;

    public GenerateReportTask(AuditTrail auditTrail)
    {
        _auditTrail = auditTrail;
    }

    public void Execute()
    {
        _auditTrail.Record();

        Console.WriteLine("Generating Report");
    }
}