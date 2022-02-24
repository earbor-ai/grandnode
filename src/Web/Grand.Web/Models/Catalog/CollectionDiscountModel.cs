using Grand.Business.Catalog.Utilities;
using Grand.Infrastructure.Models;
using Grand.Web.Models.Media;
using System;
using System.Collections.Generic;


//CSD -Created on 12/12/2021
//To represent discount at collection level instead of product level
namespace Grand.Web.Models.Catalog
{
    public partial class CollectionDiscountModel : BaseEntityModel
    {
        public CollectionDiscountModel()
        {            

        }

        public string Name { get; set; }
        public string DiscountId { get; set; }
        public DateTime StartDateUtc { get; set; }
        public DateTime EndDateUtc { get; set; }

    }
}