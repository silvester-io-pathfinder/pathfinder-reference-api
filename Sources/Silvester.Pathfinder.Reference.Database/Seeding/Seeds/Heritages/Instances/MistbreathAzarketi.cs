using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class MistbreathAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Mistbreath Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You descend from azarketis who migrated to land environments that could support their need for water. Over time, your people adapted to life on land culturally and physically, even resulting in azarketis born with human hair like their Azlanti ancestors. You no longer need to be immersed in water every 24 hours to maintain your skin and can instead mist or wipe your skin with water to live comfortably. Your land Speed is 25 feet, but your swim Speed is only 15 feet." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You no longer need to be immersed in water every 24 hours to maintain your skin and can instead mist or wipe your skin with water to live comfortably.");
            builder.ModifySpecificSpeed(Guid.Parse(""), MovementMethod.Walking, ModifierType.Add, modifier: 5);
            builder.ModifySpecificSpeed(Guid.Parse(""), MovementMethod.Swimming, ModifierType.Subtract, modifier: 15);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AzarketiAncestryWebSupplement.ID,
                Page = 3
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
