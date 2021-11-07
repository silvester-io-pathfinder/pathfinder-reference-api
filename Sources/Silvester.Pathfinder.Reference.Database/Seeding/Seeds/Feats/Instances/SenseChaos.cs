using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseChaos : Template
    {
        public static readonly Guid ID = Guid.Parse("4488595b-4506-4a06-9d88-dca2a6a1176a");

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
            yield return new TextBlock { Id = Guid.Parse("770c96af-9ccd-43b5-a0f8-5e286dcf5f86"), Type = TextBlockType.Text, Text = "You sense chaos as an unsettling feeling of nervous energy. When in the presence of an aura of chaos that is powerful or overwhelming (Pathfinder Core Rulebook page 328), you eventually detect the aura, though you might not do so instantly and you can’t pinpoint the location. This is a vague sense, similar to humans’ sense of smell. A chaotic creature using a disguise or otherwise trying to hide its presence attempts a Deception check against your Perception DC to hide its aura from you. If the creature succeeds at its Deception check, it is temporarily immune to your Sense Chaos for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b6bea8a4-cc06-410e-b2df-73e2b95bbc9e"), Feats.Instances.HellknightDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("727a339e-b3d7-438a-b73a-fe91bef1262a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
