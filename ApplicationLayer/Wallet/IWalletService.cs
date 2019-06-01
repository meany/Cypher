// Cypher (c) by Tangram Inc
// 
// Cypher is licensed under a
// Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
// 
// You should have received a copy of the license along with this
// work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>.

using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;
using TangramCypher.ApplicationLayer.Actor;
using TangramCypher.ApplicationLayer.Coin;
using TangramCypher.Model;

namespace TangramCypher.ApplicationLayer.Wallet
{
    public interface IWalletService
    {
        Task<ulong> AvailableBalance(SecureString identifier, SecureString password);
        KeySetDto CreateKeySet();
        Task<CredentialsDto> CreateWallet();
        SecureString NewID(int bytes = 32);
        SecureString Passphrase();
        byte[] HashPassword(SecureString passphrase);
        Task<ulong> TotalTransactionAmount(SecureString identifier, SecureString password, string stamp);
        Task<TransactionDto> LastTransaction(SecureString identifier, SecureString password, TransactionType transactionType);
        Task<TransactionCoin> SortChange(SecureString identifier, SecureString password, ulong amount);
        byte[] NetworkAddress(CoinDto coin, NetworkApiMethod networkApi = null);
        byte[] NetworkAddress(byte[] pk, NetworkApiMethod networkApi = null);
        string ProverPassword(SecureString password, int version);
        Task<string> Profile(SecureString identifier, SecureString password);
        Task<IEnumerable<string>> WalletList();
        ulong MulWithNaT(ulong value);
        ulong DivWithNaT(ulong value);
    }
}