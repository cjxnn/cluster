using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clustering
{
    class Reader
    {
        public Data get_data(string path)
        {
            //handle exceptions: ArgumentNullException, DirectoryNotFoundException, FileNotFoundException, IOException, NotSupportedException
            var lines = File.ReadAllLines(path);
            
            var metadata = lines[0].Split(' ').Select(elem => Int32.Parse(elem)).ToList();

            var points = new double[metadata[0], metadata[1]];
            List<double> coordinates;
            for (var i = 1; i < metadata[0] + 1; i++) {
                coordinates = lines[i].Split('\t').Select(elem => Double.Parse(elem)).ToList();
                for (var j = 0; j < metadata[1]; j++)
                    points[i-1, j] = coordinates[j];
            }

            return new Data(metadata[0], metadata[1], metadata[2], metadata[3], metadata[4] == 1, points);
        }
    }
}