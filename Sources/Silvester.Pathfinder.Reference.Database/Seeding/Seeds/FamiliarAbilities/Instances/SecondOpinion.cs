using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class SecondOpinion : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Second Opinion", 
                Description = "Your familiar is your academic confidant. Despite being a minion, your familiar gains 1 reaction at the start of its turns, which it can use only to Aid you on a Recall Knowledge skill check for a skill in which it has the skilled familiar ability (it still has to prepare to help you as normal for the Aid reaction). It automatically succeeds at its check to Aid you with those skills or automatically critically succeeds if you're a master of the skill in question. Your familiar must have the skilled ability to select this."
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
