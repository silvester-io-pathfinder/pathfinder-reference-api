using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("88b87606-92d5-4f5b-ad0b-32bf85f690d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Evolution",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0195b525-acc5-4db9-986d-ab2b09e9b5c2"), Type = TextBlockType.Text, Text = "The divine might provided by your bloodline flows through you. You gain an additional spell slot of your highest level, which you can use only to cast your choice of (spell: heal) or (spell: harm). You can cast either of these spells using that spell slot, even if they aren’t in your spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("6e41a2df-36d5-4351-8930-17981fe39c47"), Bloodlines.Instances.Divine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2dc3627-26a4-44cf-81db-6f100b259292"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
