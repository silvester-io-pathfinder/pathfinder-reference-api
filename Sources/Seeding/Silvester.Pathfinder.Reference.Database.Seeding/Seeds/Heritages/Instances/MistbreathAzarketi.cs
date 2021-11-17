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
        public static readonly Guid ID = Guid.Parse("64d20342-b3ed-46c6-a8af-84c85d080b71");

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
            yield return new TextBlock { Id = Guid.Parse("a5f542e4-a106-48c9-8b18-2c57784a545f"), Type = TextBlockType.Text, Text = "You descend from azarketis who migrated to land environments that could support their need for water. Over time, your people adapted to life on land culturally and physically, even resulting in azarketis born with human hair like their Azlanti ancestors. You no longer need to be immersed in water every 24 hours to maintain your skin and can instead mist or wipe your skin with water to live comfortably. Your land Speed is 25 feet, but your swim Speed is only 15 feet." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("87070f37-2d32-4aec-8d31-d94c77b21e41"), "You no longer need to be immersed in water every 24 hours to maintain your skin and can instead mist or wipe your skin with water to live comfortably.");
            builder.ModifySpecificSpeed(Guid.Parse("fd6160e0-50fe-4f28-939a-cee9199e63a6"), MovementMethod.Walking, ModifierType.Add, modifier: 5);
            builder.ModifySpecificSpeed(Guid.Parse("2eeb98f7-1b9e-43d1-9a8e-213b788dbb1b"), MovementMethod.Swimming, ModifierType.Subtract, modifier: 15);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ea3057a-2c93-4f68-afdb-b177efd25a0b"),
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
