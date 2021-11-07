using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("24f61a76-6db1-4e8f-b301-d2c247dd5616");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07e88e75-871d-4f0b-9e0e-ce757fb764a5"), Type = TextBlockType.Text, Text = "When you focus your magic on an ally, you can remove harmful conditions. If your next action is to (activity: Cast a Spell) from a spell slot, and that spell targets only a single ally, you can also attempt to remove a harmful condition from that ally. The condition must be one that could be removed by your (feat: Mercy) feat, including those granted by later feats such as (feat: Greater Mercy). Attempt a counteract check based on the spell’s DC and level. This effect is in addition to the normal effects of your spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f78a4cc-4b2d-4736-9aef-d15c9557f555"), Feats.Instances.BlessedOneDedication.ID);
            //TODO: Add prerequisites.
            builder.HaveSpecificFeat(Guid.Parse("837d5b4f-272e-44d0-abc9-c9c602738853"), Feats.Instances.Mercy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63c4c8fe-b8aa-4865-9ad9-35eb8316246c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
