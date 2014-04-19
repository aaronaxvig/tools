using System;
using System.Collections.Generic;
using System.Text;

namespace Axvigs.Aaron.PotD.X201403
{
    public static class X20140312
    {
        public static double GetAngle(Time time)
        {
            if (time == null)
            {
                throw new ArgumentNullException("time");
            }

            double hourHandPosition = ((double) time.Hour) * (360 / 24);
            hourHandPosition += (360 / 24) * (((double) time.Minute) / 60);

            double minuteHandPosition = ((double) time.Minute) * (360 / 60);

            double angle = hourHandPosition - minuteHandPosition;

            if (angle < 0)
            {
                angle += 360;
            }

            if (angle > 180)
            {
                angle = angle - (2 * (angle - 180));
            }

            return angle;
        }
    }

    public class Time
    {
        /// <summary>
        /// Hours in a range of 0-23
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// Minutes in a range of 0-59
        /// </summary>
        public int Minute { get; set; }
    }
}