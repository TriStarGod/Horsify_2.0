﻿using Horsesoft.Music.Data.Model.Horsify;
using System.Collections.Generic;

namespace Horsesoft.Music.Horsify.Repositories.Services
{
    /// <summary>
    /// Used for the A-Zs searching with types
    /// </summary>
    /// <seealso cref="Horsesoft.Music.Horsify.Base.Interface.IHorsifyDataTableRepo" />
    public class HorsifyDataTableRepo : IHorsifyDataTableRepo
    {
        private IHorsifySongService _horsifySongService;

        public HorsifyDataTableRepo(IHorsifySongService horsifySongService)
        {
            _horsifySongService = horsifySongService;              
        }

        public IEnumerable<string> GetEntries(SearchType searchType, char firstChar)
        {
            return _horsifySongService.GetAllFromTableAsStrings(searchType, firstChar.ToString(), -1);
        }

        public IEnumerable<string> GetEntries(SearchType searchType, string searchTerm, short maxAmount = -1)
        {
            return _horsifySongService.GetAllFromTableAsStrings(searchType, searchTerm, maxAmount);
        }
    }
}
