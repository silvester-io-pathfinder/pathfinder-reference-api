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
        public static readonly Guid ID = Guid.Parse("a563db62-91fd-4ede-acce-11f29a92e8c8");

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
            yield return new TextBlock { Id = Guid.Parse("2b1cba6e-bc33-4e84-854e-911707fb2714"), Type = TextBlockType.Text, Text = "You trace your lineage from azarketis who lived their lives among the great oceans and seas of the world. You know how to use the currents and the primal magic of water to guide your attacks. You gain the Underwater Marauder skill feat, and your piercing ranged attacks don't have their range increments halved when fighting underwater targets." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("39241369-5dd8-4382-9371-dbcd953f3df8"), Feats.Instances.UnderwaterMarauder.ID);
            builder.Manual(Guid.Parse("c2129b36-4168-4a33-9ae9-58c941330008"), "Your piercing ranged attacks don't have their range increments halved when fighting underwater targets.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc0d4e04-96b4-4a13-a47c-35791f39f9c1"),
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
