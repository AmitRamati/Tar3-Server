namespace Tar2.BL
{
    public class Flat
    {
        int id;
        string city;
        string address;
        int numOfRooms;
        double price;

        static List<Flat> FlatList=new List<Flat>();

        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public int NumOfRooms { get => numOfRooms; set => numOfRooms = value; }
        public double Price { get => price;
            set {
                if(value>100 && numOfRooms > 1)
                {
                    price = value * 0.9;
                }
                else { price = value; }
            } }

        
        public Flat() { }
      
        public Flat (int id, string city, string address,int numOfRooms, double price)
        {
            Id = id;
            City = city;
            Address = address;
            NumOfRooms = numOfRooms;
            Price = price;
        }

        public int Insert()
        {
            DBservices dbs = new DBservices();
            return dbs.InsertFlat(this);
        }

        public List<Flat> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadFlats();
        }

        public List<Flat> GetByCityAndPrice(string city, double price)
        {
            List<Flat> selectedFlat=new List<Flat>();
            foreach (Flat f in FlatList)
            {
                if(f.city==city && f.price<price)
                    selectedFlat.Add(f);
            }
            return selectedFlat;
        }

    }
}
