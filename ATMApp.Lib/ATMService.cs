using ATMApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ATMApp.Lib
{
    public class ATMService
    {
        private List<Account> accounts = [];
        private Account? currentAccount = null;

        public string GetCurrentAccountName()
        {
            return currentAccount?.FullName ?? "";
        }

        public int GetCurrentBalance()
        {
            return currentAccount!.Balance ;
        }

        public async Task LoadAccountsAsync(string path)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(path);

            if (!File.Exists(path))
            {
                return;
            }

            var json = await File.ReadAllTextAsync(path);
            accounts = JsonSerializer.Deserialize<List<Account>>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web)) ?? [];
        }

        public async Task WriteAccountAsync(string path)
        {
            await File.WriteAllTextAsync(path,JsonSerializer.Serialize(accounts));
        }

        public bool Login(string cardNumber, int pin)
        {
            currentAccount = accounts.SingleOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);
            return currentAccount != null;
        }

        public bool Withdraw(int amount)
        {
            if (currentAccount is null)
            {
                throw new Exception("No current account found!");
            }

            if (currentAccount.Balance < amount)
            {
                return false;
            }

            currentAccount.Balance -= amount;

            currentAccount.Transactions.Add(new AccountTransaction
            {
                TransactionDate = DateTime.Now,
                Amount = amount
            }) ;
            return true;
        }
    }
}
