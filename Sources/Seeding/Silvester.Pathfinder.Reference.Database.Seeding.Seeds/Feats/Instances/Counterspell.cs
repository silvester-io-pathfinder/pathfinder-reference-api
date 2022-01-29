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
    public class Counterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("a2688d4c-8af6-4631-98c2-533ccd830c5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Counterspell",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: primal), or (trait: occult)).",
                Trigger = "A creature Casts a Spell that you have prepared.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ea87200-0e88-409e-ad52-5ba2adf8db7f"), Type = TextBlockType.Text, Text = $"When a foe {ToMarkdownLink<Models.Entities.Rule>("Casts a Spell", Rules.Instances.CastASpell.ID)} and you can see its manifestations, you can use your own magic to disrupt it. You expend a prepared spell to counter the triggering creature's casting of that same spell. You lose your spell slot as if you had cast the triggering spell. You then attempt to counteract the triggering spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e841c71-1d9c-4a9b-bc8a-e13c142f32ba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
