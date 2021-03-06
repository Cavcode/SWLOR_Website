﻿using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class GrowingPlant
    {
        public int GrowingPlantID { get; set; }
        public int PlantID { get; set; }
        public int RemainingTicks { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public int TotalTicks { get; set; }
        public int WaterStatus { get; set; }
        public int LongevityBonus { get; set; }

        public Plant Plant { get; set; }
    }
}
