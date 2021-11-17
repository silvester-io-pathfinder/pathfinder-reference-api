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
    public class JinxedTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("ba27760d-82e2-411b-a1af-1d4be4c75566");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Jinxed Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c1d0e767-9f29-4f94-b660-bcfdd2391c4b"), Type = TextBlockType.Text, Text = "Your lineage has been exposed to curse after curse, and now, they slide off your feathers like rain. If you succeed at a saving throw against a curse or misfortune effect, you get a critical success instead. When you would gain the doomed condition, attempt a DC 17 flat check. On a success, reduce the value of the doomed condition you would gain by 1." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("b7a9b705-9be2-4462-a124-57b7bc48160c"), Traits.Instances.Curse.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("8abf41c0-b54d-4a36-95dd-6c1bca0503ae"), Traits.Instances.Misfortune.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.Manual(Guid.Parse("314ff91e-f18b-4ec0-aca5-c7511bf9393f"), "When you would gain the doomed condition, attempt a DC 17 flat check. On a success, reduce the value of the doomed condition you would gain by 1.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff0875cb-ec9e-4264-a25a-1a7d817a4c09"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 25
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Tengu.ID;
        }
    }
}
