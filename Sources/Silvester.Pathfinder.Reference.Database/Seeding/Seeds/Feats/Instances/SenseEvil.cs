using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("6ec26125-d166-41ec-b8e6-7463c06e9674");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Evil",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7b027d1-4112-4bb2-9148-873108968de1"), Type = TextBlockType.Text, Text = "You sense evil as a queasy or foreboding feeling. When in the presence of an aura of evil that is powerful or overwhelming (page 328), you eventually detect the aura, though you might not do so instantly, and you can’t pinpoint the location. This acts as a vague sense, similar to humans’ sense of smell. An evil creature using a disguise or otherwise trying to hide its presence attempts a Deception check against your Perception DC to hide its aura from you. If the creature succeeds at its Deception check, it is then temporarily immune to your Sense Evil for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("c158c2ef-a179-4035-96f3-0ae2353084af"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("333fba41-6e30-4fcf-8071-96933e1ee171"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
