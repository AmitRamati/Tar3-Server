namespace Tar2.BL
{
    public class Vacation 
    {
        int vacationId;
        int flatId;
        string userId;
        DateTime startDate;
        DateTime endDate;

        static List<Vacation> vacationsList = new List<Vacation>();
        public Vacation()
        {

        }
        public Vacation(int vacationId, int flatId, string userId, DateTime startDate, DateTime endDate)
        {
            VacationId = vacationId;
            FlatId = flatId;
            UserId = userId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int VacationId { get => vacationId; set => vacationId = value; }
        public int FlatId { get => flatId; set => flatId = value; }
        public string UserId { get => userId; set => userId = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public int Insert()
        {
            DBservices dbs = new DBservices();
            return dbs.InsertVacation(this);
        }

        public List<Vacation> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadVacations();
        }

        public List <Vacation> GetByDate(DateTime StartDate, DateTime EndDate) 
        {
            List<Vacation> selectedVacations= new List<Vacation>(); 

            foreach(Vacation v in vacationsList)
            { 
                if(StartDate <= v.startDate && EndDate >= v.endDate)
                {
                    selectedVacations.Add(v);
                }
            }
            return selectedVacations;
        }


    }


}
