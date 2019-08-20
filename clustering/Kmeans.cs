using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clustering
{
    class Kmeans {
        Data data;
        double[,] means;
        int[] clusters;
 
        public Kmeans(Data data){
            this.data = data;
            clusters = new int[data.Num_points];
            means = new double[data.Num_clusters,data.Dim];
        }

        public int[] Get_clusters()
        { 
            initialise();

            bool success = true;
            bool changed = true;
            int iter = 0;
            while (changed == true && success == true && iter < data.Iter_max)
            {
                iter += 1;
                success = update_means();
                changed = update_clusters();
            }
            return clusters;
        }

        private void initialise()
        { 
            Random random = new Random();

            for (var i = 0; i < data.Num_clusters; i++) 
                clusters[i] = i;

            for (var i = data.Num_clusters; i < data.Num_points; i++)
                clusters[i] = random.Next(0, data.Num_clusters); 
        }
  
        private bool update_means()
        {
            int[] clusterCounts = new int[data.Num_clusters];
            for (var i = 0; i < data.Num_points; i++)
                clusterCounts[clusters[i]]++;

            for (var i = 0; i < data.Num_clusters; i++)
                if (clusterCounts[i] == 0)
                    return false;

            for (var i = 0; i < data.Num_points; i++)
                for (var j = 0; j < data.Dim; j++)
                    means[clusters[i],j] += data.Points[i,j];

            for (var i = 0; i < data.Num_clusters; i++)
                for (var j = 0; j < data.Dim; j++)
                    means[i,j] /= clusterCounts[i];

            return true;
        }

        private bool update_clusters()
        {
            bool changed = false;
            for (var i = 0; i < data.Num_points; i++)
            {
                double dist_min = Double.MaxValue;
                int index_min = 0;
                double dist;

                for (var j = 0; j < data.Num_clusters; j++){
                    dist = 0.0;
                    for (var k = 0; k < data.Dim; k++)
                        dist += Math.Pow((data.Points[i,k] - means[j,k]), 2);
                    if (dist < dist_min){
                        dist_min = dist;
                        index_min = j;
                    }
                }
                if (clusters[i] != index_min){
                    clusters[i] = index_min;
                    changed = true;
                }
            }

            return changed;
        }
    }
}