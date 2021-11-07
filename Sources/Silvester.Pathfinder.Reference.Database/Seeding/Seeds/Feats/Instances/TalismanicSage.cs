using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanicSage : Template
    {
        public static readonly Guid ID = Guid.Parse("6cc0f093-d9b1-4128-a3c8-200320cbb4e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Talismanic Sage",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3e07638-c9ce-4fa3-b939-e995545d2976"), Type = TextBlockType.Text, Text = "You have forgotten more about talismans than lesser warriors have ever known. Normally, affixing more than one talisman to an item causes the talismans to be suppressed, but when you (action: Affix a Talisman), you can specially treat one item you’re working on, allowing it to have two active talismans at once. This special treatment ends if you use (action: Affix a Talisman) to treat a new item for this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("191e4e8d-27ce-4976-9cf2-b38be00b4090"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a41cf9e4-179f-4143-ae19-b339b2202e02"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
