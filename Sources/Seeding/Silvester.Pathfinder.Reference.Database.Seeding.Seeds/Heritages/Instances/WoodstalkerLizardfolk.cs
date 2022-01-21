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
    public class WoodstalkerLizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("68c93b01-bf45-45f6-a506-4ead103205e7");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Woodstalker Lizardfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4c1ba8b7-1759-485d-9ebd-ffb1be58e393"), Type = TextBlockType.Text, Text = "You move easily through thick forest and jungle, using every branch or bush. You can always use the Take Cover action when in forest or jungle terrain to gain cover, even if you're not next to an obstacle you would normally be able to Take Cover behind. You gain the Terrain Stalker feat, even if you're not trained in Stealth, and you must choose underbrush as your chosen terrain." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("592e7094-c05b-4af9-91a7-c94b7ad6f30d"), "You can always use the Take Cover action when in forest or jungle terrain to gain cover, even if you're not next to an obstacle you would normally be able to Take Cover behind.");
            builder.DisableFeatPrerequisites(Guid.Parse("f8e45426-de36-4e47-b90f-e9cb3593d1db"), Feats.Instances.TerrainStalker.ID);
            builder.GainSpecificFeat(Guid.Parse("7c1e1e22-242d-4828-9d03-f0a485ed55c2"), Feats.Instances.TerrainStalker.ID, restrictions: "You must choose underbrush as your chosen terrain.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c34fefc-bf04-43f5-87db-ea7b8a9e4423"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 45
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Lizardfolk.ID;
        }
    }
}
