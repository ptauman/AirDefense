namespace AirDefense.Dal
{
    // מחלקה שמחזירה מודל של מסד הנתונים כסינגלטון
    public class Data
    {
        private readonly string _connectionString = "server=M\\SA;initial catalog=Library_Test; user id=SA;" +
            "password=1234;TrustServerCertificate=Yes";

        // משתנה שיחזיק את כל המופע של המחלקה הנוכחית
        private static Data _data;
        // משתנה מחלקה שיחזיק את מופע מסד הנתונים
        private DataLayer DataLayer;
        // בנאי פרטי שניתן לגשת אליו רק מתוך המחלקה
        private Data()
        {
            DataLayer = new DataLayer(_connectionString);
        }
        // משתנה סטטי לקבלת המודל הנוכחי שמחזיק מופע של מסד הנתונים
        public static DataLayer Get
        {
            // אם המשתנה של מחלקה זו טרם הוגדר נפעיל את הבנאי ונחזיר את המשתנה שמחזיק את מסד הנתונים 
            get
            {
                if (_data == null)
                    _data = new Data();
                return _data.DataLayer;
            }
        }
    }
}
