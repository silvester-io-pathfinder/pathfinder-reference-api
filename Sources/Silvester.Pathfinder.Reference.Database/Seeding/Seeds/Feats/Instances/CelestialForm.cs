using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialForm : Template
    {
        public static readonly Guid ID = Guid.Parse("433dd945-bbc5-4e95-b05c-ae082cae2fd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Form",
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
            yield return new TextBlock { Id = Guid.Parse("a4e66ee1-a49f-4e00-96c4-83adfd733189"), Type = TextBlockType.Text, Text = "You take on a celestial countenance, appearing like a type of celestial who serves your deity; for example, as an angel, you would gain a halo and feathery wings. You gain a fly Speed equal to your Speed. You gain darkvision if you don’t already have it, and you gain the (trait: celestial) trait and the trait appropriate to the type of servitor you’ve become (archon, angel, or azata, for example)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("6c68a1a0-8ff2-4d00-aefa-075e8768e911"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b911ad47-4dcf-487b-92d8-853c8d9b4a0d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
