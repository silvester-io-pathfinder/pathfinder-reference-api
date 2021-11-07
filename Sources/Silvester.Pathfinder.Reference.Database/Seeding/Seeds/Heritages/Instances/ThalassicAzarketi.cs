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
    public class ThalassicAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Thalassic Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You trace your lineage from azarketis who lived their lives among the great oceans and seas of the world. You know how to use the currents and the primal magic of water to guide your attacks. You gain the Underwater Marauder skill feat, and your piercing ranged attacks don't have their range increments halved when fighting underwater targets." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.UnderwaterMarauder.ID);
            builder.Manual(Guid.Parse(""), "Your piercing ranged attacks don't have their range increments halved when fighting underwater targets.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AzarketiAncestryWebSupplement.ID,
                Page = 4
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
