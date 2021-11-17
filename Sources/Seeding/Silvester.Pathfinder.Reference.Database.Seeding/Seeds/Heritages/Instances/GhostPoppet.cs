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
    public class GhostPoppet : Template
    {
        public static readonly Guid ID = Guid.Parse("0a218de2-2098-4f2c-acb1-11e224f547e4");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ghost Poppet"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("076e7985-9e95-488c-9150-aaae01bb4d49"), Type = TextBlockType.Text, Text = "You awakened when a bit of another person's life force and a fragment of their soul�possibly, but not always, at the moment of their death�found its way into your constructed body. You don't remember anything more than vague flashes of your �before life,� but that life essence still protects you. You gain resistance to negative damage equal to half your level (minimum 1)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("e7e65f90-d8ed-451f-afe4-c9b18105338a"), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8de9ef9e-2ef5-490f-b735-623ea17ffd2d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 62
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Poppet.ID;
        }
    }
}
