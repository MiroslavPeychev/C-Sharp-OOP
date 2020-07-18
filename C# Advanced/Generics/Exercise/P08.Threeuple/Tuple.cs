namespace P08.Threeuple
{
    public class Tuple<TFirst, TSecond, TThird>
    {
        public Tuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public TFirst FirstItem { get; set; }

        public TSecond SecondItem { get; set; }

        public TThird ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}"; 
        }
    }
}