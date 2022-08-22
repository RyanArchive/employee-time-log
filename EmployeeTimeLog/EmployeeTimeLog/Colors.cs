using System.Drawing;

namespace EmployeeTimeLog
{
    class Colors
    {
        private static readonly Color grayTemp = Color.FromArgb(0xA2A2A3);
        private static readonly Color greenTemp = Color.FromArgb(0x2EB82E);
        private static readonly Color orangeTemp = Color.FromArgb(0xEA7D1C);
        private static readonly Color redTemp = Color.FromArgb(0xE10A16);
        private static readonly Color yellowTemp = Color.FromArgb(0xE1D205);

        private readonly Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        private readonly Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);
        private readonly Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);
        private readonly Color red = Color.FromArgb(redTemp.R, redTemp.G, redTemp.B);
        private readonly Color yellow = Color.FromArgb(yellowTemp.R, yellowTemp.G, yellowTemp.B);

        public Color Gray
        {
            get { return gray; }
            set { }
        }

        public Color Green
        {
            get { return green; }
            set { }
        }

        public Color Orange
        {
            get { return orange; }
            set { }
        }

        public Color Red
        {
            get { return red; }
            set { }
        }

        public Color Yellow
        {
            get { return yellow; }
            set { }
        }
    }
}
