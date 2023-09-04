namespace DataManager.Models.EF
{
    public class Table1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Drunk { get; set; }

        public List<Table2> TableList { get; set; }

    }
}
