namespace Tree.@class
{
    public class Holder : IComparable  //מחזיק
    {
        private Entity entity;
        private float legalPercentage; //שיעור אחזקה משפטי
        private float economicPercentage; //שיעור אחזקה כלכלי

        #region constractors
        public Holder(Entity entity, float legalPercentage, float economicPercentage)
        {
            Entity = entity;
            LegalPercentage = legalPercentage;
            EconomicPercentage = economicPercentage;
        }
        #endregion

        #region GET/SET
        public Entity Entity
        {
            get { return entity; }
            set { entity = value; }
        }
        public float LegalPercentage
        {
            get { return legalPercentage; }
            set { legalPercentage = value; }
        }
        public float EconomicPercentage
        {
            get { return economicPercentage; }
            set { economicPercentage = value; }
        }
        #endregion

        #region ToString/Equals/CompareTo
        public override string ToString()
        {
            return Entity.ToString() + ", LegalPercentage: " + LegalPercentage + ", EconomicPercentage: " + EconomicPercentage;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Holder h)
                return Entity.Equals(obj) &&
                    LegalPercentage == h.LegalPercentage &&
                    EconomicPercentage == h.EconomicPercentage;
            return false;
        }
        public int CompareTo(object? obj) //מיון לפי שיעור אחזקה כלכלי
        {
            if (obj is Holder h)
                return (int)(EconomicPercentage*100 - h.EconomicPercentage*100);

            return -1;
        }
        #endregion
    }
}

