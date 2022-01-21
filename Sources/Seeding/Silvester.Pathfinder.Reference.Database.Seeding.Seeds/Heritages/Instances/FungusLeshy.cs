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
    public class FungusLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("0419bdd4-f312-4d54-bcb1-0a5cd2be39c9");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fungus Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("41630ce7-980a-461c-9fca-1930163378d5"), Type = TextBlockType.Text, Text = "Your body was made from fungi that grows in the shade of caves and trees, and you are at home in dark caverns and warrens. You gain darkvision. You lose the plant trait and gain the fungus trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("8d4addde-22a0-460e-a2b5-35f25a357c25"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.LoseSpecificTrait(Guid.Parse("77462c87-bb04-4536-abc9-daf314dc1398"), Traits.Instances.Plant.ID);
            builder.GainSpecificTrait(Guid.Parse("c4d01a7c-cdc3-4fd7-bad9-cc19f545e6fe"), Traits.Instances.Fungus.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9ddd8c8-4805-4100-9809-ffb3e1f50035"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
