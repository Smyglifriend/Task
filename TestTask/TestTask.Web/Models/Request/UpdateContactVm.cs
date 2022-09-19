namespace TestTask.Web.Models.Request;

public class UpdateContactVm
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string JobTitle { get; set; }

    public string DateOfBirth { get; set; }

    public string MobilePhone { get; set; }
}