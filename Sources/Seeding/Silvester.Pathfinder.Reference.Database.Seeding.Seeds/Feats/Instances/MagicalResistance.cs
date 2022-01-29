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
    public class MagicalResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("c155007e-fd4d-4bcd-a5e1-2f6146d1dd4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Resistance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a875939e-707b-4df2-bf2c-28aed63871dd"), Type = TextBlockType.Text, Text = $"Your animating magic provides some defense. Choose one of the following energy damage types: cold, electricity, or sonic. You gain resistance 5 to that damage type." };
            yield return new TextBlock { Id = Guid.Parse("646300e3-3dd2-426d-9fe1-b909e42de892"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("98962f14-21f5-43a2-a9fe-11d6b8fe50ed"), Type = TextBlockType.Text, Text = $"~ Enhancement: You tap deeper into your animating magic, and your resistances improve. Choose one of the following benefits: you gain resistance 5 to the remaining two damage types from the above list, or your chosen resistance increases to a value equal to 1 + half your level." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2173a286-980e-491b-9d31-26578f83f053"), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e19a63a-eaa8-4377-9120-e0fa8e641edd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
