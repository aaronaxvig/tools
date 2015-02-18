namespace Axvigs.Aaron.PotD.X201502
{
    public static class X20150210
    {
        public static int GetLuckyNumberCount(int start, int end)
        {
            int count = 0;

            for (int i = start; i <= end; i++)
            {
                string number = i.ToString();

                if (number.Length == 3 || number.Length == 7)
                {
                    count++;
                }
                else
                {
                    int countThrees = 0;

                    foreach (char letter in number)
                    {
                        if (letter == '3')
                        {
                            countThrees++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int countSevens = 0;

                    foreach (char letter in number)
                    {
                        if (letter == '7')
                        {
                            countSevens++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if(countThrees==number.Length || countSevens==number.Length)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}