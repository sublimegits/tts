using NAudio.Wave;
using System.Speech.Synthesis;
using System.Windows.Forms;
using static TTSToVCable.Form1;

namespace TTSToVCable
{

    public partial class Form1 : Form
    {
        private SpeechSynthesizer synth = new();
        private AudioDevice? selectedDevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enumerate all output devices and add to dropdown
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var capabilities = WaveOut.GetCapabilities(i);
                AudioDevice audiodevice = new(i, capabilities.ProductName);
                toolStripDropDownButton1.DropDownItems.Add(audiodevice.Name);
                toolStripDropDownButton1.DropDownItems[i].Click += DeviceMenuItem_Click; // wired per item
                toolStripDropDownButton1.DropDownItems[i].Tag = audiodevice;
            }

            if (toolStripDropDownButton1.DropDownItems.Count > 0)
            {
                ((ToolStripMenuItem)toolStripDropDownButton1.DropDownItems[0]).PerformClick();
            }
        }

        private void DeviceMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item && item.Tag is AudioDevice device)
            {
                selectedDevice = device;
                toolStripDropDownButton1.Text = device.Name;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void SpeakButton_Click(object sender, EventArgs e)
        {
            if (selectedDevice == null) { toolStripStatusLabel1.Text = "Select an output first!"; return; }

            synth.SetOutputToNull();

            var ms = new MemoryStream();
            synth.SetOutputToWaveStream(ms);
            synth.Speak(textBox1.Text);
            ms.Position = 0;

            var waveOut = new WaveOut();
            waveOut.DeviceNumber = selectedDevice.DeviceIndex;
            waveOut.Init(new WaveFileReader(ms));
            waveOut.Play();
        }

        public class AudioDevice
        {
            public int DeviceIndex { get; }
            public string Name { get; }

            public AudioDevice(int index, string name)
            {
                DeviceIndex = index;
                Name = name;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
