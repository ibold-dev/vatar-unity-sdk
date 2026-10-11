using System.Threading;
using System.Threading.Tasks;

namespace Vatar.Games
{
    /// <summary>
    /// Implement this interface in the game to pass purchase claims to its own backend.
    /// The backend must verify and deliver purchases through the Vatar Games API.
    /// </summary>
    public interface IVatarEntitlementService
    {
        Task ClaimPurchaseAsync(string sessionToken, string purchaseId, CancellationToken cancellationToken);
    }
}
