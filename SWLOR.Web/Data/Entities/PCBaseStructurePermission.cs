﻿using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBaseStructurePermission
    {
        public int PCBaseStructurePermissionID { get; set; }
        public int PCBaseStructureID { get; set; }
        public string PlayerID { get; set; }
        public bool CanPlaceEditStructures { get; set; }
        public bool CanAccessStructureInventory { get; set; }
        public bool CanEnterBuilding { get; set; }
        public bool CanRetrieveStructures { get; set; }
        public bool CanAdjustPermissions { get; set; }
        public bool CanRenameStructures { get; set; }
        public bool CanEditPrimaryResidence { get; set; }
        public bool CanRemovePrimaryResidence { get; set; }

        public PCBaseStructure PCBaseStructure { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
