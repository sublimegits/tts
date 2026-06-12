using NAudio.Gui;
using NAudio.Wave;
using NAudio.WinForms;
using System;
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
            waveViewer1.SamplesPerPixel = 128;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            if (toolStripDropDownButton2.DropDownItems.Count > 0)
            {
                ((ToolStripMenuItem)toolStripDropDownButton2.DropDownItems[0]).PerformClick();
            }
        }

        private void DeviceMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item && item.Tag is AudioDevice device)
            {
                selectedDevice = device;
                toolStripDropDownButton1.Text = device.Name;
                toolStripStatusLabel1.Text = "Selected device";
            }
        }

        private void VoiceMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item && item.Tag is VoiceS voice)
            {
                selectedVoice = voice;
                toolStripDropDownButton2.Text = voice.Name;
                toolStripStatusLabel1.Text = "Selected voice";
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
            if (selectedVoice == null) { toolStripStatusLabel1.Text = "Select a voice first!"; return; }

            synth.SetOutputToNull();

            var ms = new MemoryStream();
            synth.SetOutputToWaveStream(ms);
            synth.SelectVoice(selectedVoice.Name);
            synth.Volume = trackBar1.Value;
            synth.Rate = trackBar2.Value;
            synth.Speak(textBox1.Text);
            ms.Position = 0;

            var waveOut = new WaveOut
            {
                DeviceNumber = selectedDevice.DeviceIndex
            };
            var ws = new WaveFileReader(ms);

            waveViewer1.StartPosition = 0;
            waveViewer1.SamplesPerPixel = (int)((ws.Length / ws.BlockAlign) / waveViewer1.Width);
            waveViewer1.WaveStream = ws;
            waveViewer1.Refresh();

            ws.Position = 0;

            waveOut.Init(ws);
            waveOut.Play();
            
            toolStripStatusLabel1.Text = "Talked succesfully";
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

        private void waveViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
