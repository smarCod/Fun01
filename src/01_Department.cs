




namespace Fun01.src;

public interface IDepartment
{
    string Name { get; set; }
    void AddSection(ISection section);
    void DeleteSection(ISection section);
    void PrintSections();
    void PrintSectionConsumerValues();
}

public class Department : IDepartment
{
    public virtual string Name { get; set; } = string.Empty;
    List<ISection> SectionList { get; set; } = new List<ISection>();

    public void AddSection(ISection section)
    {
        SectionList.Add(section);
    }
    public void DeleteSection(ISection section)
    {
        SectionList.Remove(section);
    }

    public void PrintSections()
    {
        foreach (var item in SectionList)
        {
            Console.WriteLine(item.IdentificationSection);
        }
    }

    public void PrintSectionConsumerValues()
    {
        foreach (var item in SectionList)
        {
            Console.WriteLine(item.IdentificationSection + " " + this.Name);
            item.PrintConsumerValues();
        }
    }
}

public class DepAH42 : Department
{
    public override string Name { get; set; } = "DepAH42";
}
public class DepFB8C : Department
{
    public override string Name { get; set; } = "DepFB8C";
}