using System;

namespace Vatar.Games
{
    public enum VatarErrorCode
    {
        Unknown,
        NotFramed,
        Timeout,
        RateLimited,
        Busy,
        Cancelled,
        PaymentFailed,
        NotForSale,
        Owned,
        Off,
        NotAvailable,
        SignedOut,
        TooSoon,
        FriendlyOnly,
        Limit,
        NotFound,
        NotOpen,
        NotMultiplayer,
        BadRequest,
        UnsupportedPlatform
    }

    public sealed class VatarException : Exception
    {
        public VatarErrorCode Code { get; }

        public VatarException(VatarErrorCode code, string message)
            : base(message)
        {
            Code = code;
        }
    }
}
