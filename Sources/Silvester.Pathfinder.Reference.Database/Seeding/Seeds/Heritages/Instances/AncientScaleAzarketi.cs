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
    public class AncientScaleAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ancient Scale Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your lineage stems from azarketis who remain dedicated to their deep-sea roots. Divorced from land society, you're a foreigner to any world above a thousand fathoms deep. You gain darkvision. Your body is dotted with phosphorescent spots that emit a guiding light and help you communicate. The spots—located primarily on your face, arms, and hands—illuminate a 10-foot radius around you with dim light. You can activate, deactivate, or change the arrangement of lights as an action, which has the concentration trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.Manual(Guid.Parse(""), "Your body is dotted with phosphorescent spots that emit a guiding light and help you communicate. The spots—located primarily on your face, arms, and hands—illuminate a 10-foot radius around you with dim light. You can activate, deactivate, or change the arrangement of lights as an action, which has the concentration trait.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
