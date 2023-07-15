﻿using CommerceClone.Models;

namespace CommerceClone.Interfaces
{
    public interface IStoreRepository
    {
        IEnumerable<Store> GetStoresByAdmin(Admin admin);
        IEnumerable<Store> GetStoresByAdmin(string username);
    }
}
