namespace GraphicsApp
{
    public abstract class GraphicFunction
    {
        protected virtual string? _displayName { get; set; } = null;
        public static GraphicFunction[] GetAllFunctions() => new GraphicFunction[]{ 
            new FirstSinWave(), 
            new SecondSinWave(), 
            new ThirdSinWave() 
        };

        public abstract IEnumerable<Point> GetPoints(double from, double to, double step, double scale);

        public override string ToString() => _displayName != null ? _displayName :  this.GetType().Name;


        //R = A * sin(6t) * cos(t)

        private class FirstSinWave : GraphicFunction
        {
            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                //throw new NotImplementedException();
                for (double angle = from; angle < to; angle += step)
                {
                    var r = scale * 2 * angle;
                    yield return new Point
                    {
                        X = (int)Math.Round(r * Math.Cos(angle)),
                        Y = (int)Math.Round(r * Math.Sin(angle))
                    };
                }
            }
        }

        private class SecondSinWave : GraphicFunction
        {
            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                throw new NotImplementedException();
            }
        }

        private class ThirdSinWave : GraphicFunction
        {
            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                throw new NotImplementedException();
            }
        }
    }
}
