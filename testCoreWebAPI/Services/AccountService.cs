using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testCoreWebAPI.Models;
using testCoreWebAPI.Models.DataBaseContext;

namespace testCoreWebAPI.Services
{
    public class AccountService : RESTfullService<Account>
    {
        public AccountService() : base() { }
        AccountContext _db;

        public async override Task<Account> GetImpl(int accountId)
        {
            var account = await _db.Accounts.FindAsync(accountId);
            return account;
        }

        public async override Task<Account> PostImpl(Account account)
        {
            _db.Accounts.Add(account);
            await _db.SaveChangesAsync();
            return account;
        }

        public async override Task<Account> PutImpl(Account account)
        {
            if (!_db.Accounts.Any(x => x.Id == account.Id))
            {
                return null;
            }

            _db.Update(account);
            await _db.SaveChangesAsync();
            return account;
        }

        public async override Task<Account> DeleteImpl(int accountId)
        {
            Account account = _db.Accounts.FirstOrDefault(x => x.Id == accountId);
            if (account == null)
                return null;
            _db.Accounts.Remove(account);
            await _db.SaveChangesAsync();
            return account;
        }
    }
}
