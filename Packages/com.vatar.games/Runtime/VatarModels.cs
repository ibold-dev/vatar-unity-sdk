using System;
using System.Collections.Generic;

namespace Vatar.Games
{
    public enum VatarMode
    {
        Test,
        Live
    }

    public sealed class VatarPlayer
    {
        public string Id { get; }
        public string Name { get; }
        public string AvatarDataUrl { get; }

        internal VatarPlayer(string id, string name, string avatarDataUrl)
        {
            Id = id;
            Name = name;
            AvatarDataUrl = avatarDataUrl;
        }
    }

    public sealed class VatarSession
    {
        public string Token { get; }
        public DateTimeOffset ExpiresAt { get; }

        internal VatarSession(string token, DateTimeOffset expiresAt)
        {
            Token = token;
            ExpiresAt = expiresAt;
        }
    }

    public sealed class VatarInitialization
    {
        public VatarPlayer Player { get; }
        public VatarSession Session { get; }
        public VatarMode Mode { get; }

        internal VatarInitialization(VatarPlayer player, VatarSession session, VatarMode mode)
        {
            Player = player;
            Session = session;
            Mode = mode;
        }
    }

    public sealed class VatarPurchase
    {
        public string PurchaseId { get; }
        public string ProductId { get; }

        internal VatarPurchase(string purchaseId, string productId)
        {
            PurchaseId = purchaseId;
            ProductId = productId;
        }
    }

    public sealed class VatarScoreResult
    {
        public long Best { get; }
        public bool Accepted { get; }

        internal VatarScoreResult(long best, bool accepted)
        {
            Best = best;
            Accepted = accepted;
        }
    }

    public sealed class VatarLeaderboardEntry
    {
        public int Rank { get; }
        public string Name { get; }
        public long Score { get; }

        internal VatarLeaderboardEntry(int rank, string name, long score)
        {
            Rank = rank;
            Name = name;
            Score = score;
        }
    }

    public sealed class VatarLeaderboardMe
    {
        public int? Rank { get; }
        public string Label { get; }
        public long Score { get; }

        internal VatarLeaderboardMe(int? rank, string label, long score)
        {
            Rank = rank;
            Label = label;
            Score = score;
        }
    }

    public sealed class VatarLeaderboard
    {
        public IReadOnlyList<VatarLeaderboardEntry> Top { get; }
        public VatarLeaderboardMe Me { get; }

        internal VatarLeaderboard(IReadOnlyList<VatarLeaderboardEntry> top, VatarLeaderboardMe me)
        {
            Top = top;
            Me = me;
        }
    }
}
