using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CSharpCube
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        LedCube ledCube = new LedCube();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.AGENT' table. You can move, or remove it, as needed.
            label1.Text = ledCube.leds[0].x.ToString("G") + " " + ledCube.leds[0].y.ToString("G") + " " + ledCube.leds[0].z.ToString("G");
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 38400;
            _serialPort.PortName = "COM20";
           // _serialPort.Open();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serialPort.Write("{000FF0000}");
            _serialPort.Write("{001FF0000}");
            _serialPort.Write("{002FF0000}");
            _serialPort.Write("{003FF0000}");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPort.Close();
        }
    }
}
