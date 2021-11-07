using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseForTrouble : Template
    {
        public static readonly Guid ID = Guid.Parse("57373f8c-2310-49eb-8a30-20baf50c0135");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense for Trouble",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a483b94-1f8b-4d1a-a02b-345fc3df97df"), Type = TextBlockType.Text, Text = "You can tell when something’s off. You can trigger (feat: Cat’s Luck) after you roll initiative, in addition to its normal trigger, to reroll your Initiative and take the higher of the two results. This still counts against (feat: Cat’s Luck’s | Cat&#39;s Luck) frequency, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("27fe8ee6-e5f5-46e2-98d4-c26a242ade64"), Feats.Instances.CatsLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b47b1df-caee-49f1-8c68-6722728e479a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
