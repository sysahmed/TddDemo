namespace TddDemo.Entities
{
    public class EgnPartsEntity
    {
        private string _egn;

        public string egn
        {
            get { return _egn; }
            set { _egn = value; }
        }

        public int year
        {
            get
            {
                return int.Parse(egn.Substring(0, 2));
            }

        }
        public int month
        {
            get
            {
                int month = int.Parse(egn.Substring(2, 2));
                if (month > 40)
                {
                    return month -= 40;
                }
                else if (month > 20)
                {
                    return month -= 20;
                }
                else
                {
                    return month;
                }
            }
            set
            {
                month = int.Parse(egn.Substring(2, 2));
            }
        }
        public int day
        {
            get
            {
                return int.Parse(egn.Substring(4, 2));
            }
        }

    }
}
