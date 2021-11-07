using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfinitePossibilities : Template
    {
        public static readonly Guid ID = Guid.Parse("9311a873-7e73-4cab-8719-481c2ce723b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Infinite Possibilities",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("939f9199-3be3-42c1-baab-5fba23b071f0"), Type = TextBlockType.Text, Text = "You’ve found a way to prepare a spell slot that exists in your mind as many different possibilities at once. Once during your daily preparations, you can use a spell slot to hold that infinite potential, rather than using it to prepare a spell. You can use this spell slot to cast any spell from your spellbook that’s at least 2 levels lower than the slot you designate; the spell acts in all ways as a spell of 2 levels lower. You don’t have any particular spell prepared in that slot until you cast it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3724241c-42d2-4dae-a2d2-01a3c2d15c01"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
