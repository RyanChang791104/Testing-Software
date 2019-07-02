using System.ComponentModel;
using System.Drawing;

namespace XML_Program
{
    [DisplayName("DeviceContainer")]
    public class DeviceContainer
    {
        public double _Lat = 38;
        private Color _color;
        private string _file = string.Empty;
        private Font _font;

        public string FileName
        {
            get { return _file; }
            set { _file = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        public double Lat
        {
            get { return _Lat; }
            set { _Lat = value; }
        }
    }

    [DisplayName("SlotContainer")]
    public class SlotContainer
    {
        private double _Lat = 44;
        private Font _font;

        public Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        public double Lat
        {
            get { return _Lat; }
            set { _Lat = value; }
        }
    }

    [DisplayName("I2CBus")]
    public class I2CBus
    {
        [Category("I2CBus"), Description("Bus"), ReadOnly(true)]
        private string _Bus = "Bus0";

        private string _CommDevice = "Adq10Device1";
        private string _Description = "I2CBus";
        private bool _Enabled = false;
        private string _Port = "DIO_C";

        public string Bus
        {
            get { return _Bus; }
            set { _Bus = value; }
        }

        public string CommDevice
        {
            get { return _CommDevice; }
            set { _CommDevice = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public bool Enabled
        {
            get { return _Enabled; }
            set { _Enabled = value; }
        }

        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
        }
    }

    public class ArrayList
    {
        private string _StationName;
        private double _Lon = 103;
        private double _Lat = 38;
        private Color _color;
        private string _file = string.Empty;
        private Font _font;

        public string FileName
        {
            get { return _file; }
            set { _file = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        public string StationName
        {
            get { return _StationName; }
            set { _StationName = value; }
        }

        public double Lon
        {
            get { return _Lon; }
            set { _Lon = value; }
        }

        public double Lat
        {
            get { return _Lat; }
            set { _Lat = value; }
        }
    }
}