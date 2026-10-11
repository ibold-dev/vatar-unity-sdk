using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Vatar.Games
{
    // Browser interop is introduced behind this boundary so consumers never depend on .jslib details.
    internal static class VatarBridge
    {
        private static Task<T> Unsupported<T>()
        {
            return Task.FromException<T>(new VatarException(
                VatarErrorCode.UnsupportedPlatform,
                "Vatar Games is available only in a Unity WebGL build running inside the Vatar game player."));
        }

        internal static Task<VatarInitialization> InitializeAsync(CancellationToken cancellationToken) => Unsupported<VatarInitialization>();
        internal static Task<VatarSession> GetSessionAsync(CancellationToken cancellationToken) => Unsupported<VatarSession>();
        internal static Task<VatarPurchase> PurchaseAsync(string productId, CancellationToken cancellationToken) => Unsupported<VatarPurchase>();
        internal static Task<IReadOnlyList<VatarPurchase>> GetPendingPurchasesAsync(CancellationToken cancellationToken) => Unsupported<IReadOnlyList<VatarPurchase>>();
        internal static Task<VatarScoreResult> SubmitScoreAsync(long score, CancellationToken cancellationToken) => Unsupported<VatarScoreResult>();
        internal static Task<VatarLeaderboard> GetLeaderboardAsync(CancellationToken cancellationToken) => Unsupported<VatarLeaderboard>();
    }
}
