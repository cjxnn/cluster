using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clustering
{
    class Data
    {
        public readonly int Num_points;
        public readonly int Dim;
        public readonly int Num_clusters;
        public readonly int Iter_max;
        public readonly bool Has_name;
        public readonly double[,] Points;

        public Data(int num_points, int dim, int num_clusters, int iter_max, bool has_name, double[,] points) {
            Num_points = num_points;
            Dim = dim;
            Num_clusters = num_clusters;
            Iter_max = iter_max;
            Has_name = has_name;
            Points = points;
        }
    }
}