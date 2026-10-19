using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiGi.WebTracker
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the MD5 hash of the page at <paramref name="url"/>, used for change detection.
        /// </summary>
        /// <param name="client">The HTTP client used to fetch the page.</param>
        /// <param name="url">The URL of the page to hash.</param>
        /// <returns>The lowercase MD5 hash of the page content, or <see langword="null"/> when the inputs are invalid.</returns>
        public static async Task<string?> PageHash(HttpClient? client, string? url)
        {
            if(client is null || string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            try
            {
                string @string = await client.GetStringAsync(url);
#pragma warning disable CA5351 // MD5 is used for page-change detection, not cryptographic security.
                using MD5 md5 = MD5.Create();
#pragma warning restore CA5351
                byte[]? hashBytes = md5?.ComputeHash(Encoding.UTF8.GetBytes(@string));
                return Convert.ToHexString(hashBytes ?? []).ToLowerInvariant();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ Error fetching page: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
