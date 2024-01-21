using ATMApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ATMApp.Lib
{
    public class ATMService
    {
        private List<Account> accounts = [];

        public async Task LoadAccountsAsync(string path)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(path);

            if (!File.Exists(path))
            {
                return;
            }

            var json = await File.ReadAllTextAsync(path);
            accounts = JsonSerializer.Deserialize<List<Account>>(json) ?? [];
        }
    }
}
