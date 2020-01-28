﻿using MyGameStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGameStore.Models
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}