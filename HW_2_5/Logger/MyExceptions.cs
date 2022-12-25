using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5.Logger
{
    public class SpeedOutOfRangeException : Exception
    {
        private int LowerBound => 0;
        private int UpperBound => 900;
        public override string Message => "Incorrect speed";
        public override IDictionary Data => new Dictionary<string, int>
        {
            {nameof(LowerBound), LowerBound},
            {nameof(UpperBound), UpperBound}
        };
    }
    public class WeightOutOfRangeException : Exception
    {
        private int LowerBound => 900;
        private int UpperBound => 100000;
        public override string Message => "Incorrect weight";
        public override IDictionary Data => new Dictionary<string, int>
        {
            {nameof(LowerBound), LowerBound},
            {nameof(UpperBound), UpperBound}
        };
    }
}
