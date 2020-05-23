﻿using Accommodation.Core.Models.HotelInformations;
using Accommodation.Core.Models.HotelReservations;
using System.Collections.Generic;

namespace Accommodation.Core.Models.Hotels
{
    public class HotelViewModel
    {
        public string Id { get; set; }
        public string MerchantFid { get; set; }
        public string UniqueId { get; set; }
        public int SourceFid { get; set; }
        public string SourceResKey { get; set; }
        public string HotelCode { get; set; }
        public string ChainCode { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public string HotelName { get; set; }
        public string HotelShortName { get; set; }
        public string WhenBuild { get; set; }
        public string StartOperation { get; set; }
        public int StatusFid { get; set; }
        public string StatusResKey { get; set; }
        public int HotelCategoryFid { get; set; }
        public string HotelCategoryResKey { get; set; }
        public int HotelTypeFid { get; set; }
        public string HotelTypeResKey { get; set; }
        public int TotalRooms { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int MapCapturedFileStreamFid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int CityFid { get; set; }
        public string Country { get; set; }
        public int CountryFid { get; set; }
        public string FullAddress { get; set; }
        public bool ActiveForOperation { get; set; }
        public List<HotelReservationViewModel> hotelReservationLst { get; set; }        
        public List<HotelInformationViewModel> hotelInforLst { get; set; }
    }
}