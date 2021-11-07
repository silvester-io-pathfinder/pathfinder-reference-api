using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WyrmlingFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("b7e80c4b-fbd5-40b1-9e25-db287da69c6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wyrmling Flight",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f8f7886-5003-44d6-8afd-44dc7c3f348a"), Type = TextBlockType.Text, Text = "Your draconic wings have grown large and strong enough for flight. You gain a fly Speed equal to your Speed, using your wings to stay aloft." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3170ed2b-4b93-46ce-8328-5e430b651b53"), Feats.Instances.HatchlingFlight.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebc492b3-74b2-49b7-b259-edd8d2e900df"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
