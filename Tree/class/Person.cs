namespace Tree.@class
{
    public class Person : Entity, IComparable //בנ"א
    {
        private DateOnly bournDate;

        #region constracors
        public Person(string id, string name) : base(id, name) { }
        public Person(string id, string name, DateOnly bournDate) : base(id, name)
        {
            BournDate = bournDate;
        }
        #endregion

        #region GET/SET
        public DateOnly BournDate
        {
            get { return bournDate; }
            set { bournDate = value; }
        }
        #endregion

        #region ToString/Equals/CompareTo
        public override string ToString()
        {
            return base.ToString() + ", " + BournDate.ToString();
        }
        public override bool Equals(object? obj)
        {

            if (obj is Person p)
                return base.Equals(obj) && BournDate.Equals(p.BournDate);

            return false;
        }
        public int CompareTo(object? obj) //מיון לפי תאריך לידה
        {
            if (obj is Person p)
                return BournDate.CompareTo(p.BournDate);

            return -1;
        }
        #endregion
    }
}
