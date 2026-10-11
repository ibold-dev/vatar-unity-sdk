using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Vatar.Games
{
    /// <summary>
    /// Entry point for the Vatar Games SDK. It is available only in a Unity WebGL build
    /// running inside a supported Vatar game player.
    /// </summary>
    public static class VatarClient
    {
        public static VatarInitialization Current { get; private set; }

        public static event Action<VatarPurchase> PurchaseCompleted;
        public static event Action Paused;
        public static event Action Resumed;

        public static Task<VatarInitialization> InitializeAsync(CancellationToken cancellationToken = default)
        {
            return VatarBridge.InitializeAsync(cancellationToken);
        }

        public static Task<VatarSession> GetSessionAsync(CancellationToken cancellationToken = default)
        {
            return VatarBridge.GetSessionAsync(cancellationToken);
        }

        public static Task<VatarPurchase> PurchaseAsync(string productId, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(productId))
            {
                throw new ArgumentException("A product ID is required.", nameof(productId));
            }

            return VatarBridge.PurchaseAsync(productId, cancellationToken);
        }

        public static Task<IReadOnlyList<VatarPurchase>> GetPendingPurchasesAsync(CancellationToken cancellationToken = default)
        {
            return VatarBridge.GetPendingPurchasesAsync(cancellationToken);
        }

        public static Task<VatarScoreResult> SubmitScoreAsync(long score, CancellationToken cancellationToken = default)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Scores cannot be negative.");
            }

            return VatarBridge.SubmitScoreAsync(score, cancellationToken);
        }

        public static Task<VatarLeaderboard> GetLeaderboardAsync(CancellationToken cancellationToken = default)
        {
            return VatarBridge.GetLeaderboardAsync(cancellationToken);
        }

        internal static void SetCurrent(VatarInitialization initialization) => Current = initialization;
        internal static void RaisePurchaseCompleted(VatarPurchase purchase) => PurchaseCompleted?.Invoke(purchase);
        internal static void RaisePaused() => Paused?.Invoke();
        internal static void RaiseResumed() => Resumed?.Invoke();
    }
}
