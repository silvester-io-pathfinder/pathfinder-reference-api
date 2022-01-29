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
    public class PierceTheDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("2c4eeb96-f237-449c-874a-38189efe4613");

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
            yield return new TextBlock { Id = Guid.Parse("34833178-e017-4827-b51a-2a2fda79c2bd"), Type = TextBlockType.Text, Text = $"Your eyes have adapted to see in all circumstances, even without the assistance of light. You gain darkvision, allowing you to see in darkness and dim light just as well as you can in bright light. However, in darkness you see in black and white only." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("e40b172c-9287-4522-9e3e-32851600b9a7"), Senses.Instances.LowLightVision.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c32a0767-e4e8-49e1-bede-081ef89e621c"), Traits.Instances.Goloma.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5272bc24-ce29-4c7b-95c8-8c76c3acfaec"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
