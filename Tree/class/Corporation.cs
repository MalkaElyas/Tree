namespace Tree.@class
{
    public class Corporation : Entity, IComparable//תאגיד
    {
        private static int count = 0;
        private TypeEntity typeEntity; //סוג יישות
        private DateOnly incorporationDate; //תאריך הקמה
        private List<Holder> holder; //רשימת מחזיקים
        private List<System> systems; //רשימת מערכות
        private List<Loan> loan; //רשימת הלוואות

        #region constractors

        #endregion

        #region GET/SET
        public TypeEntity TypeEntity
        {
            get { return typeEntity; }
            set { typeEntity = value; }
        }
        public DateOnly IncorporationDate
        {
            get { return incorporationDate; }
            set { incorporationDate = value; }
        }
        public List<Holder> Holder
        {
            get { return holder; }
            set { holder = value; }
        }
        public List<System> Systems
        {
            get { return systems; }
            set { systems = value; }
        }
        public List<Loan> Loan
        {
            get { return loan; }
            set { loan = value; }
        }
        #endregion

        #region ToString/Equals/CompareTo

        #endregion
    }
}
