using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainWindows
{
    public class Startup
    {
        public async Task<object> Invoke(object input)
        {
            int layer_number = (int)input;
            return PcbProject.LoadLayer(layer_number);
        }
    }

    public static class PcbProject
    {
        public static string LoadLayer(int layer_number)
        {
            string project_folder = "C:\\Users\\cruzc\\Documents\\Proyectos\\angular-connect-2015-write-once-run-anywhere\\layers_data";
            string path = project_folder + "\\" + layer_number + ".json";
            string readText = File.ReadAllText(path);
            return readText;
        }
    }
}
