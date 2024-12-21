namespace Tree.@class
{
    public class Entity : IComparable //יישות
    {
        private string id; //ת.ז או מס' תאגיד
        private string name; //שם מלא

        #region constractors
        public Entity() { }
        public Entity(string id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion

        #region GET/SET
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
        #endregion

        #region ToString/Equals/CompareTo
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Entity e)
                return e.id == Id && e.name == Name;

            return false;
        }
        public int CompareTo(object? obj)//מיון לפי ID
        {
            if (obj is Entity e)
            {
                return Id.CompareTo(e.id);
            }

            return -1;
        }
        #endregion
    }
}
