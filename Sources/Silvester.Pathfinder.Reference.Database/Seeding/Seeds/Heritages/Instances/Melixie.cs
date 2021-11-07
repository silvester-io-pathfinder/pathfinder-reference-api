using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Melixie : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Melixie"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have the features of a bee, butterfly, or other insect that loves sweets. You can ask questions of and receive answers from arthropods (insects, spiders, scorpions, crabs, and similar invertebrate animals), as well as use Diplomacy to Make an Impression on and Request things of them. Most bees, butterflies, moths, and beetles have an indifferent or friendly starting attitude toward you and give you time to make your case, though other arthropods react to you like any other adventurer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You can ask questions of and receive answers from arthropods (insects, spiders, scorpions, crabs, and similar invertebrate animals), as well as use Diplomacy to Make an Impression on and Request things of them.");
            builder.Manual(Guid.Parse(""), "Most bees, butterflies, moths, and beetles have an indifferent or friendly starting attitude toward you and give you time to make your case, though other arthropods react to you like any other adventurer.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 129
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Sprite.ID;
        }
    }
}
