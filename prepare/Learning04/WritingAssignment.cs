public class WritingAssgnment : Assignment
{
    private string _title;

    public WritingAssgnment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetstudentName();

        return $"{_title} by {studentName}";
    }

}
