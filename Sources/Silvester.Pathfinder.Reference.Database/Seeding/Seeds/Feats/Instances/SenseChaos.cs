using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseChaos : Template
    {
        public static readonly Guid ID = Guid.Parse("e8b522bb-7f2b-4871-82e6-a81c1a76da44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Chaos",
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
            yield return new TextBlock { Id = Guid.Parse("0682a139-6d79-48fb-ad78-05cf3d025564"), Type = TextBlockType.Text, Text = "You sense chaos as an unsettling feeling of nervous energy. When in the presence of an aura of chaos that is powerful or overwhelming (Pathfinder Core Rulebook page 328), you eventually detect the aura, though you might not do so instantly and you can’t pinpoint the location. This is a vague sense, similar to humans’ sense of smell. A chaotic creature using a disguise or otherwise trying to hide its presence attempts a Deception check against your Perception DC to hide its aura from you. If the creature succeeds at its Deception check, it is temporarily immune to your Sense Chaos for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60763d53-d54c-4d66-9452-9bfcd2ddcc8d"), Feats.Instances.HellknightDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f9ef362-80e3-4729-abb6-b6d370c80904"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
