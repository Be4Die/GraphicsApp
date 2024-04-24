namespace GraphicsApp
{
    public partial class Form1 : Form
    {
        private double _graphicsScale;
        private GraphicFunction _graphicFunctions;
        private readonly Pen _pen = new Pen(Brushes.Green, 5);
        public Form1()
        {
            InitializeComponent();

            var funcs = GraphicFunction.GetAllFunctions();
            functionsComboBox.DataSource = funcs;
            _graphicFunctions = funcs[0];
        }



        private void OnScaleValueChanged(object sender, EventArgs e)
        {
            _graphicsScale = scaleTrackBar.Value;
            pictureBox.Invalidate();
        }

        private void OnPaintPictureBox(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            var points = _graphicFunctions.GetPoints(0, 2 * Math.PI, 0.01, _graphicsScale);
            Point? prev = null;
            foreach (var point in points)
            {
                if (prev != null)
                    g.DrawLine(_pen, Translate(prev.Value), Translate(point));
                prev = point;
            }
        }

        private Point Translate(Point point) => new Point(point.X + pictureBox.Width / 2, point.Y + pictureBox.Height / 2);

        private void OnSelectedFunctionChanged(object sender, EventArgs e)
        {
            var func = functionsComboBox.SelectedItem as GraphicFunction;
            if (func == null)
                return;

            _graphicFunctions = func;
            pictureBox.Invalidate();
        }

        private void OnFromResize(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
