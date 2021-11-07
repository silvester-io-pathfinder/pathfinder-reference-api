using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PierceTheDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("ae268f04-6ded-43a4-a186-4fb88a40aaa7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pierce the Darkness",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("105ffb2b-eaaa-44b0-bd80-adb70b2c3e15"), Type = TextBlockType.Text, Text = "Your eyes have adapted to see in all circumstances, even without the assistance of light. You gain darkvision, allowing you to see in darkness and dim light just as well as you can in bright light. However, in darkness you see in black and white only." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("fed71e85-ce71-417e-b71f-167218036e8d"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c77f20a-ecb8-4200-908a-2da567b563f6"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
