using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Ambassador : Template
    {
        public static readonly Guid ID = Guid.Parse("d2aa2a36-12b5-49d8-9778-743ffa9def2b");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Ambassador", 
                Description = "Your familiar knows how to act cute or focused on cue, helping you make a good impression. Despite being a minion, your familiar gains 1 reaction at the start of its turns, which it can use only to Aid you on a Diplomacy check to Make an Impression (it still has to prepare to help you as normal for the Aid reaction, which requires it to participate throughout the activity). It automatically succeeds at its check to Aid you with those skills or automatically critically succeeds if you're a master of the skill in question."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac295b6f-5e53-4ed4-9b9e-9b6ff88bcbc3"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
