using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;

namespace ScreenRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            videoCapture1.Screen_Capture_Source = new VisioForge.Types.Sources.ScreenCaptureSourceSettings() { FullScreen = true };

            videoCapture1.Audio_PlayAudio = videoCapture1.Audio_RecordAudio = false;

            videoCapture1.Output_Format = new VFAVIOutput();

            videoCapture1.Output_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\output.avi";

            videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.ScreenCapture;

            videoCapture1.Start();
        }
    }
}
