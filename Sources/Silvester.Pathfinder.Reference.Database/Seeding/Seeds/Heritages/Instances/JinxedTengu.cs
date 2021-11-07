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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your lineage has been exposed to curse after curse, and now, they slide off your feathers like rain. If you succeed at a saving throw against a curse or misfortune effect, you get a critical success instead. When you would gain the doomed condition, attempt a DC 17 flat check. On a success, reduce the value of the doomed condition you would gain by 1." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse(""), Traits.Instances.Curse.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse(""), Traits.Instances.Misfortune.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.Manual(Guid.Parse(""), "When you would gain the doomed condition, attempt a DC 17 flat check. On a success, reduce the value of the doomed condition you would gain by 1.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
