namespace Tree.@class
{
    public class System //מערכת
    {

        private static int count = 0;   //לצורך ID

        private int id;                 //ID אוטומטי*
        private string makat;           //מזהה מתקן - ולידציה*
        private TypeSystem typeSystem;  //סוג מתקן*
        private DateOnly bildDate;      //מועד הקמה*
        private DateOnly runDate;       //מועד הפעלה
        private float yearRuning;       //שנות הפעלה
        private DateOnly daidDate;      //תאריך הגרטת הנכס (מחושב)
        private StatusSystem status;    //סטטוס
        private double cost;            //עלות - סכום ידני פשוט**
        private double depreciation;    //פחנ"צ -      סכום ידני**
        private DateOnly depDate;       //פחנ"צ מעודכן לתאריך**
        private string idCoporation;    //מס' תאגיד*
        private string idLoan;          //מס' הלוואה


        /* להלן רעיון מקורי אבל קשה...ולא ישים כרגע
         * תאור - עלות מקור/היוון/שדרוג/חלפים-לתת אופציה של אורך חיים שונה, מופחת?/השהייה, 
         * ליסט של קלאסים המכילים: תאריך, סכום,
         * ליסט פחנצ שנרשם
         * 
         * רשימה של פחנ"צ הכוללת משתנה המכיל את התאריך החישוב וסכום הפחת
         * תאריך החישוב יהיה 2 תאריכים הראשון מ: .... והשני עד:....כך נדע על איזה תקופה חשבו
         */

        #region constractors
        public System(string makat, TypeSystem typeSystem, DateOnly bildDate, string idCoporation)
        {
            count++;
            id = count;

            Makat = makat;
            TypeSystem = typeSystem;
            BildDate = bildDate;
            Status = StatusSystem.SET_UP;
            IdCoporation = idCoporation;
        }
        #endregion

        #region GET/SET
        public string Makat  //צריך להוסיף ולידציה שבודקת כי אין מערכת נוספת עם המזהה הזה אם יש - לשים בינתיים את ה ID
        {
            get { return makat; }
            set { makat = value; }
        }
        public TypeSystem TypeSystem
        {
            get { return typeSystem; }
            set { typeSystem = value; }
        }
        public DateOnly BildDate
        {
            get { return bildDate; }
            set { bildDate = value; }
        }
        public DateOnly RunDate
        {
            get { return runDate; }
            //set { runDate = value; }
        }
        public float YearRuning
        {
            get { return yearRuning; }
            set 
            { 
                yearRuning = value;
                SetDaidDate(yearRuning);
            }
        }
        public void UpRunning(DateOnly runDate, float yearRuning)
        {
            this.runDate = runDate;
            YearRuning = yearRuning;
            Status = StatusSystem.RUN;           
        }
        public DateOnly DaidDate //אין סט היות ומחושב לפי אורך החיים
        {
            get { return daidDate; }
        }
        private DateOnly SetDaidDate(float yearRuning)//עדכון תאריך אורך החיים- פנימי למחלקה..
        {
            daidDate = runDate.AddYears((int)yearRuning);
            daidDate = daidDate.AddMonths((int)((yearRuning - (int)yearRuning) * 12));
            daidDate = daidDate.AddDays((int)((int)((yearRuning - (int)yearRuning) * 12)) * 365);

            return daidDate;
        }
        public StatusSystem Status
        {
            get { return status; }
            set { status = value; }
        }
        public double Cost //עדכון עלות - מלא
        {
            get { return cost; }
            set { cost = value; }
        }
        public void AddCost(double cost) //הוספת עלויות
        {
            Cost += cost;
        }
        public double Depreciation //היות וכאשר מעדכנים את הפחת יש לעדכן גם את תאריך הפחת - עשיתי פונקציה נפרדת
        {
            get { return depreciation; }
        }
        public DateOnly DepDate
        {
            get { return depDate; }
        }
        public void UpdateDepreciation(double depreciation, DateOnly depDate)
        {
            this.depreciation += depreciation;
            this.depDate = depDate;
        }
        public string IdCoporation
        {
            get { return idCoporation; }
            set { idCoporation = value; }
        }
        public string IdLoan
        {
            get { return idLoan; }
            set { idLoan = value; }
        }
        #endregion

        #region ToString/Equals/CompareTo
        public override string ToString()
        {
            return $"ID: {id}, Makat: {makat}, TypeSystem: {typeSystem}, BildDate: {bildDate}, " +
                   $"RunDate: {runDate}, YearRunning: {yearRuning}, DaidDate: {daidDate}, " +
                   $"Status: {status}, Cost: {cost}, Depreciation: {depreciation}, " +
                   $"DepDate: {depDate}, IdCorporation: {idCoporation}, IdLoan: {idLoan}";
        }
        public override bool Equals(object obj)
        {
            if (obj is System other)
            {
                return id == other.id &&
                       Makat == other.Makat &&
                       TypeSystem == other.TypeSystem &&
                       BildDate.Equals(other.BildDate) &&
                       RunDate.Equals(other.RunDate) &&
                       YearRuning.Equals(other.YearRuning) &&
                       DaidDate.Equals(other.DaidDate) &&
                       Status == other.Status &&
                       Cost.Equals(other.Cost) &&
                       Depreciation.Equals(other.Depreciation) &&
                       DepDate.Equals(other.DepDate) &&
                       IdCoporation == other.IdCoporation &&
                       IdLoan == other.IdLoan;
            }
            return false;
        }
        public int CompareTo(object obj)
        {
            if (obj is System other)
            {
                return BildDate.CompareTo(other.BildDate);
            }
            throw new ArgumentException("Object is not a YourClassName");
        }
        #endregion
    }
}