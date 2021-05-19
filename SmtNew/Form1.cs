using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtNew
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void figureData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_choose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }
    }
    public class Figure
    {
        protected int x;
        protected int y;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual void Draw()
        { }

        public override string ToString()
        {
            return base.ToString() + $";X={x};Y={y};";
        }
    }

    public class Line : Figure
    {
        protected int x2;
        protected int y2;

        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            // Draw line
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }
    public class Rectangle : Figure
    {
        protected int x2;
        protected int y2;

        public Rectangle(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            // Draw rectangle
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }
    public class Treangle : Figure
    {
        protected int x2;
        protected int y2;

        public Treangle(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            // Draw treangle
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }

    public class Circle : Figure
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public override void Draw()
        {
            // Draw Circle
        }

        public override string ToString()
        {
            return base.ToString() + $"R={r}";
        }
    }
    public class FiguresData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }

    static public class FigureFab
    {
        public static Figure Make(FiguresData figData)
        {
            Figure fig = null;

            switch (figData.Name)
            {
                case "Line":
                    fig = new Line(figData.Data["X1"], figData.Data["Y2"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
                case "Circle":
                    fig = new Circle(figData.Data["X"], figData.Data["Y"], figData.Data["Radius"]);
                    break;
                case "Rectangle":
                    fig = new Rectangle(figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
                case "Treangle":
                    fig = new Treangle(figData.Data["X1"], figData.Data["Y1"], figData.Data["X2"], figData.Data["Y2"]);
                    break;
            }

            return fig;
        }

        public static List<FiguresData> InitFiguresData()
        {
            var figuresData = new List<FiguresData>();

            figuresData.Add(new FiguresData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Radius", 0 }
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 },
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Rectangle",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 0 },
                    { "Y2", 0 },
                }
            });

            figuresData.Add(new FiguresData
            {
                Name = "Treangle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                }
            });

            return figuresData;
        }
    }
}
