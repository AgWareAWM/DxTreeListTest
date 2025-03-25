namespace DxTreeListTest
{
    public interface IEmployeeTaskDataProvider
    {
        public List<EmployeeTask> GenerateData();
        public List<EmployeeTask> GenerateLargeData();
    }
}
