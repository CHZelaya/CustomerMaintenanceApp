namespace CustomerData
{
    public class StateDB
    {
        public static List<State> GetStates()
        {
            using (MMABooksContext db = new MMABooksContext())
            {
                return db.States.OrderBy(s => s.StateName).ToList();
            }
        }
    }
}
