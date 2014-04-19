using System;
using System.Text;

namespace Axvigs.Aaron.PotD.X201403
{
    public static class X20140307
    {
        public static int[][] GenerateResponse(int[][] challenge)
        {
            if (challenge == null)
            {
                throw new ArgumentNullException("challenge");
            }

            int[][] response = new int[challenge.GetLength(0)][];

            for (int i = 0; i < challenge.GetLength(0); i++)
            {
                response[i] = new int[challenge.GetLength(0)];

                for (int j = 0; j < challenge.GetLength(0); j++)
                {
                    response[i][j] = challenge[challenge.GetLength(0) - j - 1][i];
                }
            }

            return response;
        }
    }
}