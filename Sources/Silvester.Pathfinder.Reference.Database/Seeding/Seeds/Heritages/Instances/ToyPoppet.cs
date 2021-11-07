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
    public class ToyPoppet : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Toy Poppet"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have the form of a child's tiny toy or doll, but you don't let your small size impede your joy of life. Instead of Small, your size is Tiny. Like other Tiny creatures, you don't automatically receive lesser cover from being in a larger creature's space, but circumstances might allow you to Take Cover. You can purchase weapons, armor, and other items for your size with the same statistics as normal gear, except that melee weapons have a reach of 0 for you (or a reach 5 feet shorter than normal if they have the reach trait). You can enter another creature's space, which is important because you must usually enter a creature's space to attack it with melee Strikes! Remember to adjust the Bulk of items and your Bulk limit for Tiny size." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse(""), AncestrySizes.Instances.Tiny.ID);
            builder.Manual(Guid.Parse(""), "You don't automatically receive lesser cover from being in a larger creature's space, but circumstances might allow you to Take Cover.");
            builder.Manual(Guid.Parse(""), "You can purchase weapons, armor, and other items for your size with the same statistics as normal gear, except that melee weapons have a reach of 0 for you (or a reach 5 feet shorter than normal if they have the reach trait).");
            builder.Manual(Guid.Parse(""), "You can enter another creature's space, which is important because you must usually enter a creature's space to attack it with melee Strikes!");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 63
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Poppet.ID;
        }
    }
}
