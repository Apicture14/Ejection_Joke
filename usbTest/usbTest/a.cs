using System.ComponentModel;

namespace usbTest
{
    public partial class a : Component
    {
        public a()
        {
            InitializeComponent();
        }

        public a(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}