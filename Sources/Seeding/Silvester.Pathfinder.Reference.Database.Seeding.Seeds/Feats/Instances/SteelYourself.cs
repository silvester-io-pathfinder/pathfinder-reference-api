using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteelYourself : Template
    {
        public static readonly Guid ID = Guid.Parse("8fafd24b-7d32-4187-bbe2-a40774de4763");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steel Yourself!",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89639ac7-5c62-49ce-bd8d-cd9452b0006a"), Type = TextBlockType.Text, Text = $"You encourage an ally to toughen up, giving them a fighting chance. Choose one ally within your marshal's aura. The ally gains temporary Hit Points equal to your Charisma modifier and a +2 circumstance bonus to Fortitude saves. Both benefits last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c148144-3652-428f-8829-dda55bfb8696"), Feats.Instances.MarshalDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9822c71f-05f3-4595-ad34-e802c366ceac"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("10e4ce7b-a6bc-4faa-84da-b2a8c26ddddd"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("f894d41d-8738-4ebd-8835-bd1ed201b938"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("2b3cd047-b75d-45b4-960b-12f04614e6b2"), Traits.Instances.Mental.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ce3f1e8-8fa3-4d0d-8daa-b03d26032a17"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
