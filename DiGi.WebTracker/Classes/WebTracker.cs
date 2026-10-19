using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Timers;

namespace DiGi.WebTracker.Classes
{
    /// <summary>
    /// Periodically fetches a URL and detects changes by comparing MD5 page hashes.
    /// </summary>
    public class WebTracker : IDisposable
    {
        private bool busy;
        private bool disposed;
        private readonly HttpClient httpClient = new();
        private string? pageHash;
        private readonly System.Timers.Timer? timer;
        private readonly string? url;
        
        /// <summary>
        /// Creates a <see cref="WebTracker"/> that polls <paramref name="url"/> every <paramref name="interval"/> milliseconds.
        /// </summary>
        public WebTracker(string? url, int interval)
        {
            timer = new System.Timers.Timer(interval);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;

            pageHash = null;

            this.url = url;
        }

        /// <summary>
        /// Releases the <see cref="HttpClient"/> and <see cref="System.Timers.Timer"/> used for polling.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    httpClient.Dispose();
                    timer?.Dispose();
                }

                disposed = true;
            }
        }

        /// <summary>
        /// Gets whether a change check is currently in progress.
        /// </summary>
        public bool Busy
        {
            get
            {
                return busy;
            }
        }

        /// <summary>
        /// Starts periodic change detection.
        /// </summary>
        public void Start()
        {
            timer?.Start();
        }

        /// <summary>
        /// Stops periodic change detection.
        /// </summary>
        public void Stop()
        {
            timer?.Stop();
        }
        
        private async Task<bool> Check()
        {
            if(busy)
            {
                return false;
            }
            
            busy = true;

            string? pageHash = await Query.PageHash(httpClient, url);

            busy = false;

            if(this.pageHash == null)
            {
                this.pageHash = pageHash;
                return true;
            }

            if(pageHash != this.pageHash)
            {
                return false;
            }

            return true;

        }

        private async void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            _ = await Check();
        }
    }
}
