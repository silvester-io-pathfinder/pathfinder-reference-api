using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Snoop : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Snoop", 
                Description = "Your familiar keeps its eyes and ears open, ready to relay every snippet of gossip it catches, helping you gather information. Despite being a minion, your familiar gains 1 reaction at the start of its turns, which it can use only to Aid you on a Diplomacy check to Gather Information (it still has to prepare to help you as normal for the Aid reaction, which requires it to participate throughout the activity). It automatically succeeds at its check to Aid you with those skills or automatically critically succeeds if you're a master of the skill in question."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
