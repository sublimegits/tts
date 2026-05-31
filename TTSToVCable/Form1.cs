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
        private VoiceS? selectedVoice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedVoice = new(synth.GetInstalledVoices()[0].VoiceInfo, synth.GetInstalledVoices()[0].VoiceInfo.Name);

            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var capabilities = WaveOut.GetCapabilities(i);
                AudioDevice audiodevice = new(i, capabilities.ProductName);
                toolStripDropDownButton1.DropDownItems.Add(audiodevice.Name);
                toolStripDropDownButton1.DropDownItems[i].Click += DeviceMenuItem_Click;
                toolStripDropDownButton1.DropDownItems[i].Tag = audiodevice;
            }

            if (toolStripDropDownButton1.DropDownItems.Count > 0)
            {
                ((ToolStripMenuItem)toolStripDropDownButton1.DropDownItems[0]).PerformClick();
            }

            for (int i = 0; i < synth.GetInstalledVoices().Count; i++)
            {
                var info = synth.GetInstalledVoices()[i].VoiceInfo;
                VoiceS voice = new(info, info.Name);
                toolStripDropDownButton2.DropDownItems.Add(voice.Name);
                toolStripDropDownButton2.DropDownItems[i].Click += VoiceMenuItem_Click;
                toolStripDropDownButton2.DropDownItems[i].Tag = voice;
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

        private void VoiceMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item && item.Tag is VoiceS voice)
            {
                selectedVoice = voice;
                toolStripDropDownButton2.Text = voice.Name;
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

        public class AudioDevice(int index, string name)
        {
            public int DeviceIndex { get; } = index;
            public string Name { get; } = name;
        }
        public class VoiceS(VoiceInfo other, string name)
        {
            public VoiceInfo VoiceOther { get; set; } = other;
            public string Name { get; set; } = name;
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
