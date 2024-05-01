namespace YoutubeDownloader
{
    using AngleSharp.Text;
    using YoutubeExplode;
    using YoutubeExplode.Videos;
    using YoutubeExplode.Videos.Streams;

    public partial class Form1 : Form
    {
        private int descargando = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textMensaje.Text = "";
            if (checkBoxPlayList.Checked)
            {
                DescargaPlayList(textUrl.Text);
            }
            else
            {
                DescargarVideo(textUrl.Text);
            }
        }
        private async void DescargarVideo(string url)
        {
            try
            {
                descargando++;
                var youtube = new YoutubeClient();
                var videoUrl = url;// "https://youtube.com/watch?v=u_yIGGhubZs";
                Mensaje("URL= " + url,Color.GreenYellow);
                var video = await youtube.Videos.GetAsync(videoUrl);
                Mensaje("descargando: " + video.Title,Color.BlueViolet);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                string videoname = $"{textDirectorio.Text}\\{QuitaCaracteres(video.Title)}.{streamInfo.Container}";
                await youtube.Videos.Streams.DownloadAsync(streamInfo, videoname);
                Mensaje("Descarga completa en: " + videoname, Color.DarkGreen);
                descargando--;
            }
            catch (Exception ex)
            {
                descargando--;
                Mensaje("Error al descrgar: " + ex.Message, Color.DarkRed);
            }
        }
        private void bntDirectorio_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textDirectorio.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private string QuitaCaracteres(string nombre)
        {
            string s = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i].IsAlphanumericAscii())
                {
                    s = s + nombre[i];
                }
            }
            return s;
        }
        private async void DescargaPlayList(string url)
        {
            try
            {
                var youtube = new YoutubeClient();
                var playlistUrl = url;
                List<string> list = new List<string>();
                await foreach (var video in youtube.Playlists.GetVideosAsync(playlistUrl))
                {
                    list.Add(video.Url);
                }
                foreach (var video in list)
                {
                    DescargarVideo(video);
                }
            }
            catch (Exception ex)
            {
                Mensaje("Error al descrgar: " + ex.Message, Color.DarkRed);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (descargando > 0)
            {
                activaControles = false;
                return;
            }
            activaControles = true;
            bool ok = true;
            if (textUrl.Text.Trim() == "")
                ok = false;
            if (textDirectorio.Text.Trim() == "")
                ok = false;
            bntDescargar.Enabled = ok;
        }
        private bool activaControles
        {
            set
            {
                textUrl.Enabled = value;
                bntDescargar.Enabled = value;
                checkBoxPlayList.Enabled = value;
                textDirectorio.Enabled = value;
                bntDirectorio.Enabled = value;
            }
        }
        public void Mensaje(string text, Color color)
        {
            textMensaje.SelectionStart = textMensaje.TextLength;
            textMensaje.SelectionLength = 0;

            textMensaje.SelectionColor = color;
            textMensaje.AppendText(text+"\r\n");
            //textMensaje.SelectionColor = textMensaje.ForeColor;
        }
    }
}