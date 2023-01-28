namespace swap_custom_button_between_flow_panels
{
    public partial class MainForm : Form
    {
        char _id = (char)64;
        public MainForm()
        {
            InitializeComponent();
            Panels = new Control[]
            {
                flowLayoutPanelLeft, flowLayoutPanelRight,
            };
            buttonAddLeft.Click += (sender, e) =>
            {
                flowLayoutPanelLeft.Controls.Add(new tagButton
                {
                    Height= 50, Width=150,
                    Name = $"tagButton{++_id}",
                    Text = $"Button {_id}",
                });
            };
            buttonAddRight.Click += (sender, e) =>
            {
                flowLayoutPanelRight.Controls.Add(new tagButton
                {
                    Height= 50, Width=150,
                    Name = $"tagButton{++_id}",
                    Text = $"Button {_id}",
                });
            };
        }
        public static Control[] Panels { get; private set; }
    }
    class tagButton : Button 
    {
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (MouseButtons.Equals(MouseButtons.Right))
            {
                Control dest;
                if(Parent.Name.Contains("Left"))
                {
                    dest = MainForm.Panels.First(_=>_.Name.Contains("Right"));
                }
                else
                {
                    dest = MainForm.Panels.First(_ => _.Name.Contains("Left"));
                }
                Parent.Controls.Remove(this);
                dest.Controls.Add(this);
            }
        }
    }
}