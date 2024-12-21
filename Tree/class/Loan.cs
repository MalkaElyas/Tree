namespace Tree.@class
{
    public class Loan  //הלוואה
    {
        
        private static int count = 0; //ID אוטומטי

        private int id;  
        private string idLoan;          //מזהה הלוואה (כפי המופיע בבנק)
        public DateOnly reservingDate;  //מועד קבלת ההלוואה
        public string gorem memamrn;    //מלווה
        //סכום הלוואה
        //תאריך פרעון סופי
        //תקופות פרעון (חודשי, רבעוני, חציוני, שנתי, בסוף התקופה)
        //הצמדה
        //מדד בסיס - לפי ממוצע כלשהו לא משנה איזה (במידה ולא צמוד יהיה 100)
        //סוג ריבית
        //שיעור הריבית (או תוספת על הפריים)
        //איך ניתן למשוך נתון זה מהאינ'??
        //רשימת פרעונות (תאריך סכום הקרן סכום הריבית הצמדת קרן הצמדה ריבית)
        //רשימת מערכות משוייכות

        //פונקציה שמחשבת את היתרה הנכונה ליום מסויים/אם אין בחירה אז להיום
        //מיתרת ההלוואה לאחר הפחתת הפרעונות שבוצעו - לפני התאריך המדובר


        #region constractors

        #endregion

        #region GET/SET
        public int Id
        {
            get { return id; }   
        }
        public string IdLoan
        {
            get { return idLoan; }
            set { idLoan = value; }
        }
        public DateOnly ReservingDate
        {
            get { return reservingDate; }
            set { reservingDate = value; }
        }

        #endregion

        #region ToString/Equals/CompareTo

        #endregion

        
        public double CalcBalanc (DateOnly d = new DateOnly())
        { 
            double balanc = this.keren; //קרן ההלוואה
            //לקחת את ההלוואה המקורית
            //להפחית ממנה את כל הפרעונות שהתאריך שלהם קטן מ d
            //לשמור את התאריך של הפרעון האחרון שהפחתנו
            //לחשב את הריבית מהתאריך האחרון עד לתאריך d
            //להוסיף את הסכום שיצא ליתרת ההלוואה

            //במידה וההלוואה צמודה - לא משנה למה
            //למשוך את הבסיס ההצמדה לפי תאריך קבלת ההלוואה
            //להפחית את התשלום הקרן בלבד
            //למשוך את המדד ידוע לתאריך d לתוך משתנה נוסף
            //להוסיף הצמדה ליתרת הקרן המחושבת לעיל

            return balanc;
        }
    }
}
