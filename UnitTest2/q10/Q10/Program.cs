using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pencil pencil = new Pencil("Dixon",3,"2B");
            BrushPen brushPen = new BrushPen("Bic", 7, "black");
            PaintBrush paintBrush = new PaintBrush("ArtMate", 15, "fan");

            MakeImage(pencil, "dog");
            MakeImage(brushPen, "cat");
            MakeImage(paintBrush, "leaning tower of pisa");


        }

        static void MakeImage(object obj, string image)
        {
            if(obj is Pencil || obj is BrushPen)
            {
                IDrawTool drawInterface = (IDrawTool)obj;
                drawInterface.Draw(image);
            }
            if(obj is PaintBrush || obj is BrushPen)
            {
                IPaintTool paintInterface = (IPaintTool)obj;
                paintInterface.Paint(image);
            }
        }
    }

    public abstract class Tool
    {
        public string type;
        public int strokeWeight;
        private double fullness = 5;

        public double Fullness
        {
            get { return fullness; }
        }

        public virtual double Refill(double amount)
        {
            fullness += amount;
            return fullness;
        }

        public abstract void PickUp();
        public abstract void PutDown();

        public Tool(string type, int strokeWeight)
        {
            this.type = type;
            this.strokeWeight = strokeWeight;
        }
    }

    public interface IDrawTool
    {
        void Draw(string doodle);
    }
    public interface IPaintTool
    {
        void Paint(string picture);
    }

    public class Pencil : Tool, IDrawTool
    {
        public string hardness;

        public void Draw(string doodle)
        {
            Console.WriteLine($"drew a {doodle}");
        }
        public override void PickUp()
        {

        }
        public override void PutDown()
        {

        }

        public Pencil(string type, int strokeWeight, string hardness):base(type,strokeWeight)
        {
            this.hardness = hardness;
        }
    }

    public class BrushPen : Tool, IDrawTool, IPaintTool
    {
        public string color;

        public void Draw(string doodle)
        {
            Console.WriteLine($"drew a {doodle}");
        }
        public void Paint(string picture)
        {
            Console.WriteLine($"painted a {picture}");
        }
        public override void PickUp()
        {

        }
        public override void PutDown()
        {

        }

        public BrushPen(string type, int strokeWeight, string color) : base(type, strokeWeight)
        {
            this.color = color;
        }
    }

    public class PaintBrush : Tool, IPaintTool
    {
        public string shape;

        public void Paint(string picture)
        {
            Console.WriteLine($"painted a {picture}");
        }
        public override void PickUp()
        {

        }
        public override void PutDown()
        {

        }

        public PaintBrush(string type, int strokeWeight, string shape) : base(type, strokeWeight)
        {
            this.shape = shape;
        }
    }
}
