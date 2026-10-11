using NUnit.Framework;
using System.Threading.Tasks;

namespace Vatar.Games.Tests
{
    public sealed class VatarClientTests
    {
        [Test]
        public async Task InitializeAsync_fails_clearly_outside_a_supported_WebGL_runtime()
        {
            VatarException exception = Assert.ThrowsAsync<VatarException>(async () => await VatarClient.InitializeAsync());

            Assert.That(exception.Code, Is.EqualTo(VatarErrorCode.UnsupportedPlatform));
        }
    }
}
