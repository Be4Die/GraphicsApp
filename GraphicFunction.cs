namespace GraphicsApp
{
    public abstract class GraphicFunction
    {
        protected virtual string? _displayName { get; set; } = null;
        public static GraphicFunction[] GetAllFunctions() => new GraphicFunction[]{ 
            new MySinWave(), 
            new Cardioid(), 
            new Cannabola() 
        };

        public abstract IEnumerable<Point> GetPoints(double from, double to, double step, double scale);

        public override string ToString() => _displayName != null ? _displayName :  this.GetType().Name;


        //R = A * sin(6t) * cos(t)

        private class MySinWave : GraphicFunction
        {
            public override string ToString() => "R = A * sin(6t) * cos(t)";

            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                for (double angel = from; angel < to; angel += step)
                {
                    var r = scale*3* Math.Sin(6 * angel) * Math.Cos(angel);
                    yield return new Point
                    {
                        X = (int)Math.Round(r * Math.Cos(angel)),
                        Y = (int)Math.Round(r * Math.Sin(angel))
                    };
                }
                yield break;

            }
        }

        private class Cardioid : GraphicFunction
        {
            public override string ToString() => "Кардиоида";

            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                for (double angel = from; angel < to; angel += step)
                {
                    var r = scale * (1 + Math.Sin(angel));
                    yield return new Point
                    {
                        X = (int)Math.Round(r * Math.Cos(angel)),
                        Y = (int)Math.Round(r * Math.Sin(angel))
                    };
                }
                yield break;

            }
        }

        private class Cannabola : GraphicFunction
        {
            public override string ToString() => "Каннабола";
            public override IEnumerable<Point> GetPoints(double from, double to, double step, double scale)
            {
                for (double angel = from; angel < to; angel += step)
                {
                    var r = -scale * (1 + Math.Sin(angel)) * (1 + 0.9 * Math.Cos(8 * angel)) * (1 + 0.1 * Math.Cos(24 * angel));
                    yield return new Point
                    {
                        X = (int)Math.Round(r * Math.Cos(angel)),
                        Y = (int)Math.Round(r * Math.Sin(angel))
                    };
                }
                yield break;

            }
        }
    }
}
