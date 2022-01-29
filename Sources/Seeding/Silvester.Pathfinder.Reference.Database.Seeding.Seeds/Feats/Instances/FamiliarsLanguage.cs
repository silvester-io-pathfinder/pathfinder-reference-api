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
    public class FamiliarsLanguage : Template
    {
        public static readonly Guid ID = Guid.Parse("da117287-dee3-49d3-8477-63ec97648874");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar's Language",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f278cf17-beaa-4898-b25f-3dec3bb549a8"), Type = TextBlockType.Text, Text = $"You've learned to speak with your familiar and other creatures like it. You can ask questions of, receive answers from, and use the Diplomacy skill with creatures of the same family of animals as your familiar. For example, if your familiar were a cat, you could gain the effects of speak with animals for any felines (including leopards, lions, and tigers, among others). This ability doesn't make them more friendly than normal. If your familiar ever changes to a different creature, you can't use this ability for 1 week while you absorb your new familiar's language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("3c16d857-26ee-42e0-bf99-11d2ecc5f52c"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bc229d3-96bc-41c9-8e8a-4d33d1252c00"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
