using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adjacency
{
    enum EColor
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        LightBlue,
        Purple,
        Gray
    }
    internal class Program
    {
        static int[,] mGraph = new int[,]
    {
       //       RED     ORN     YLW     GRN     BLUE    LBLU   PRP      GRY
       /*RED*/ {-1,     -1,     -1,     -1,     1,      -1,     -1,     5},
       /*ORN*/ {-1,     -1,     -1,     -1,     -1,     -1,     1,      -1},
       /*YLW*/ {-1,     -1,     -1,     6,      -1,     -1,     -1,     -1},
       /*GRN*/ {-1,     -1,     -1,     -1,     -1,     -1,     -1,     -1},
       /*BLU*/ {-1,     -1,     8,      -1,     -1,     1,      -1,     -1},
       /*LBL*/ {-1,     -1,     -1,     -1,     1,      -1,     -1,     0},
       /*PRP*/ {-1,     -1,     1,      -1,     -1,     -1,     -1,     -1},
       /*GRY*/ {-1,     1,      -1,     -1,     -1,     0,      -1,     -1}
    };

        static int[][] lGraph = new int[][]
        {
        /*RED*/ new int[] { (int)EColor.Blue,(int)EColor.Gray},
        /*ORN*/ new int[] { (int)EColor.Purple },
        /*YLW*/ new int[] { (int)EColor.Green},
        /*GRN*/ new int[] { },
        /*BLU*/ new int[] { (int)EColor.Yellow,(int)EColor.LightBlue},
        /*LBL*/ new int[] { (int)EColor.Blue,(int)EColor.Gray},
        /*PRP*/ new int[] { (int)EColor.Yellow},
        /*GRY*/ new int[] { (int)EColor.Orange,(int)EColor.LightBlue}
        };

        static void Main(string[] args)
        {
        }
    }
}
