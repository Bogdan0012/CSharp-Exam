namespace proj{
    public class Date{
        public int Day;
        public int Month;
        public int Year;

        public Date(){
            this.Day = this.Month = this.Year = 0;
        }
        public Date(int day, int month, int year ){
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
    }
}