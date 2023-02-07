using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE08_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y; 
            double z;
            int xIndex = 0;
            int yIndex = 0;
            int zIndex = 0;
            double[,,] computations = new double[21, 31, 3];

            for(x = -1; x <= 1; x += 0.1)
            {
                for(y = 1; y <= 4; y += 0.1)
                {
                    z = 3 * y * y + 2 * x - 1;
                    for (zIndex = 0; zIndex < 3; zIndex++)
                    {
                        double val = 0;
                        switch (zIndex)
                        {
                            case 0:
                                val = x;
                                break;
                            case 1:
                                val = y;
                                break;
                            case 2:
                                val = z;
                                break;
                        }
                        computations[xIndex, yIndex, zIndex] = val;
                    }
                    yIndex++;
                }
                xIndex++;
                yIndex = 0;
            }
        }
    }
}
