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
    public class CelestialEnvoyKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("dff80bb1-823d-4730-bd26-3818be4cce4c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Celestial Envoy Kitsune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94fbb492-502d-44f0-9c27-c541e30313f0"), Type = TextBlockType.Text, Text = "Whether due to Daikitsu's grace or faithful forebears, you have a strong connection to the divine, affording you certain protections. You gain the Invoke Celestial Privilege reaction. Your alternate form is a common Medium humanoid ancestry prevalent where you grew up (typically human), called a tailless form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("8e932294-c62d-4ca1-89c3-c5ee6e90bbd0"), Feats.Instances.InvokeCelestialPrivilege.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ccf87ab-e31f-46f7-86ce-6abba41e8306"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kitsune.ID;
        }
    }
}
