﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace AQBooking.Core.Helpers
{
    public class PagedList<T> where T:class
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        [Obsolete]
        public List<T> List { get; set; }
        public List<T> Data { get; set; }

        public bool HasPreviousPage => Page > 1;
        public bool HasNextPage => Page < TotalPages;
        public int NextPageNumber => HasNextPage ? Page + 1 : TotalPages;
        public int PreviousPageNumber => HasPreviousPage ? Page - 1 : 1;

        public PagedList(IQueryable<T> source, int page, int pageSize)
        {
            TotalItems = source.Count();
            Page = page > 0 ? page : 1;
            PageSize = pageSize > 0 ? pageSize : 10;
            TotalPages = (int)Math.Ceiling(this.TotalItems / (double)this.PageSize);
            List = source
                   .Skip(pageSize * (page - 1))
                   .Take(pageSize)
                   .ToList();
            Data = source
                   .Skip(pageSize * (page - 1))
                   .Take(pageSize)
                   .ToList();
        }
        public PagedList(List<T> source, int totalItems, int page, int pageSize)
        {
            TotalItems = totalItems;
            Page = page > 0 ? page : 1;
            PageSize = pageSize > 0 ? pageSize : 10;
            TotalPages = (int)Math.Ceiling(this.TotalItems / (double)this.PageSize);
            List = source;
            Data = source;
        }

        public PagedList()
        {
        }
    }
}




