using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HatchlingFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("0b96448b-a733-48cd-b8a4-d1f6138d6b58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hatchling Flight",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a89e1764-7c79-4ab6-bc93-17810d95d845"), Type = TextBlockType.Text, Text = "You can fly a little! You (action: Fly) up to half your Speed. If you don’t end your movement on solid ground, you fall at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1dad6c38-ddf3-4158-8669-c31af413e15e"), Feats.Instances.Winglets.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("859823b8-9e7c-4c03-a333-6e01a14af31f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
