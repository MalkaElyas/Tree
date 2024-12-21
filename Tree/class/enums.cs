namespace Tree.@class
{
                               //עסקה משותפת    חברה     שותפות
    public enum TypeEntity { PARTNERSHIP, COMPANY, JOINT_VENTURE }//סוג יישות

                           //רוח  ביו-גז  אגירה  תעריפית  מונה-נטו
    public enum TypeSystem {MONE_NETO, TAARIFIT,AGIRA,BIO_GAZ,WIND}//סוג מתקן

                              //נמכר  הפעלה   מוכן    הקמה
    public enum StatusSystem {SET_UP, PREPERED, RUN , SOLD}//סטטוס מתקן

                        //סוף התקופה   שנתי   חציוני   רבעוני     חודשי
    public enum Period { MONTHLY, QUARTERLY, MEDIAN, ANNUAL, ENDPERIOD } //תקופות בשנה

    public enum Linkage { WITHOUT, MADAD, USA, EUR } //הצמדה

    public enum Interest { FIXED, VARIABLE, PRIME } //סוג ריבית

}
