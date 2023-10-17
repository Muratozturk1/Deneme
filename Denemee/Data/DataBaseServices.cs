using LiteDB;

namespace Denemee.Data
{
    public class DataBaseServices
    {
        LiteDatabase db;
        public DataBaseServices(string path)
        {
            db = new LiteDatabase(path);
            
        }
        public void InsertData(MyData data)
        {
            var dataBaseAccess = db.GetCollection<MyData>("dataTable");
            
            //if(dataBaseAccess.Count() > 0 && dataBaseAccess.Find(x => x.Name == data.Name) != null)
            //    return;
            dataBaseAccess.Insert(data);            
                        
        }
        public List<MyData> GelenData ()
        {
            var dataBaseAccess = db.GetCollection<MyData>("dataTable");
            var retData = dataBaseAccess.FindAll().ToList<MyData>();
            return retData;
        }
    
    }
    public class MyData
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname{ get; set; }
        public string? Description { get; set; }
    }
}
