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
    public class CavernElf : Template
    {
        public static readonly Guid ID = Guid.Parse("3623e7a3-e6e0-49d6-bddf-86374cd4e5d3");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cavern Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f3e0899a-ee33-4362-bad8-d5e04a76d4ec"), Type = TextBlockType.Text, Text = "You were born or spent many years in underground tunnels or caverns where light is scarce. You gain darkvision." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("c666b43e-1e3a-408a-9480-2d00fe068f5d"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb4d8681-1857-464f-b5fa-74ebef208002"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 39
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
