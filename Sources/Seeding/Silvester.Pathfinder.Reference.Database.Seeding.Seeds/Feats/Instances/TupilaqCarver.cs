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
    public class TupilaqCarver : Template
    {
        public static readonly Guid ID = Guid.Parse("e4b9b4d9-68ff-4e52-940b-ef6cbcf877ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tupilaq Carver",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1949fc9-1c90-4552-88bb-6ad5613b8a53"), Type = TextBlockType.Text, Text = $"~ Access: Erutaki ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("ce40079b-7087-4be8-8738-9314a42254f3"), Type = TextBlockType.Text, Text = $"You know the truth behind old stories that tell of sending a fetish of bone and sinew to seek vengeance. These old magics allow you to conjure constructs with ease. Add the {ToMarkdownLink<Models.Entities.Spell>("summon construct", Spells.Instances.SummonConstruct.ID)} spell to your spell list. The constructs you summon have a distinct ivory scrimshaw appearance, and if you include a drop of blood, lock of hair, or other portion of a creature's body as part of the spell's material component, the summoned construct gains a +4 status bonus to Perception checks to sense or locate that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("4e819a37-2aba-41e8-9352-aec249a0797b"), or => 
            {
                or.HaveSpecificMagicTradition(Guid.Parse("a68a92f1-b8df-49c8-bcbb-65dbd1f79490"), MagicTraditions.Instances.Divine.ID);
                or.HaveSpecificMagicTradition(Guid.Parse("33ddc023-7449-4aca-b1bc-cea8dc73fef9"), MagicTraditions.Instances.Primal.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d25ff55-628a-4f7b-9ab2-99415d6ecb07"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
