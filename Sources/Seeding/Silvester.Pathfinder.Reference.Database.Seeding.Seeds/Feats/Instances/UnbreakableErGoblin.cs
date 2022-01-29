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
    public class UnbreakableErGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("894acdbf-cfc8-49ce-926a-3fb8598b50c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbreakable-er Goblin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96ecccc6-5729-4313-9ff1-8bdbb797f36d"), Type = TextBlockType.Text, Text = $"As hard as most unbreakable goblins are to break, you are that much harder to break. You gain 20 Hit Points from your ancestry instead of 10. When you fall, you take no falling damage. If you have the {ToMarkdownLink<Models.Entities.Feat>("Bouncy Goblin", Feats.Instances.BouncyGoblin.ID)} feat, after falling or jumping from a height of at least 20 feet, you can bounce back into the air, up to half the distance you fell (and half as far forward if you jumped). These bounces continue until you bounce less than 20 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("9b4d8de4-6ac9-471c-b144-19fb38d4576a"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8dfb3148-d1c9-4964-b971-083b5a1512ba"), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2580c26d-ca28-487e-abe8-a59cc3c7b0a2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
