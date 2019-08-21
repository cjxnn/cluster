using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clustering
{
    class Result
    {
        public readonly int[] Clusters;
        public readonly double[,] Means;

        public Result(int[] clusters, double[,] means) {
            Clusters = clusters;
            Means = means;
        }
    }
}