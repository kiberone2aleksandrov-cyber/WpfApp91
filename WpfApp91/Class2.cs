using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp91
{
    public class AudioService
    {
        private static readonly Lazy<AudioService> _instance = new Lazy<AudioService>(() => new AudioService());
        public static AudioService Instance => _instance.Value;

        private MediaPlayer _player;

        private AudioService()
        {
            _player = new MediaPlayer();
            _player.MediaEnded += (s, e) => _player.Position = TimeSpan.Zero; // зацикливание
        }

        public void Play(string uri, bool loop = true)
        {
            _player.Open(new Uri(uri, UriKind.RelativeOrAbsolute));
            _player.Volume = 0.5;
            _player.Play();
            if (!loop) _player.MediaEnded -= LoopHandler;
            else _player.MediaEnded += LoopHandler;
        }

        private void LoopHandler(object s, EventArgs e)
        {
            _player.Position = TimeSpan.Zero;
            _player.Play();
        }

        public void Pause() => _player.Pause();
        public void Stop() => _player.Stop();
        public double Volume { get => _player.Volume; set => _player.Volume = value; }
        
    }
}
