using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clustering
{
    class Writer
    {
        public void write_data(Data data, int[] clusters, string path) {
            using (StreamWriter file = new StreamWriter(path))
            {
                for (var i = 0; i < data.Num_points; i++) {
                    StringBuilder line = new StringBuilder();
                    for (var j = 0; j < data.Dim; j++)
                        line.AppendFormat("{0}\t", data.Points[i, j]);
                    line.AppendFormat("{0}", clusters[i]);
                    file.WriteLine(line);
                }
            }
        }
    }
}
