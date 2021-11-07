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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You move easily through thick forest and jungle, using every branch or bush. You can always use the Take Cover action when in forest or jungle terrain to gain cover, even if you're not next to an obstacle you would normally be able to Take Cover behind. You gain the Terrain Stalker feat, even if you're not trained in Stealth, and you must choose underbrush as your chosen terrain." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You can always use the Take Cover action when in forest or jungle terrain to gain cover, even if you're not next to an obstacle you would normally be able to Take Cover behind.");
            builder.DisableFeatPrerequisites(Guid.Parse(""), Feats.Instances.TerrainStalker.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TerrainStalker.ID, restrictions: "You must choose underbrush as your chosen terrain.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
