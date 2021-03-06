﻿namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRequiredItemList
    {
        public int QuestRequiredItemListID { get; set; }
        public int QuestID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }
        public int QuestStateID { get; set; }
        public bool MustBeCraftedByPlayer { get; set; }

        public Quest Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
