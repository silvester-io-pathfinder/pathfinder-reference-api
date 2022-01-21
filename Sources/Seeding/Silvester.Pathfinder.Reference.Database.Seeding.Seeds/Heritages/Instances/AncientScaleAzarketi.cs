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
        public static readonly Guid ID = Guid.Parse("da9e3713-1cf2-4072-97dc-e74e3326f9d2");

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
            yield return new TextBlock { Id = Guid.Parse("fb9abda1-14d4-4a3d-b61f-ea2fce4f2cee"), Type = TextBlockType.Text, Text = "Your lineage stems from azarketis who remain dedicated to their deep-sea roots. Divorced from land society, you're a foreigner to any world above a thousand fathoms deep. You gain darkvision. Your body is dotted with phosphorescent spots that emit a guiding light and help you communicate. The spots�located primarily on your face, arms, and hands�illuminate a 10-foot radius around you with dim light. You can activate, deactivate, or change the arrangement of lights as an action, which has the concentration trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("9f3b5319-407c-41ef-acbb-5311a5622479"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.Manual(Guid.Parse("387ea5de-3b0d-4f00-b082-edbdf33b18e9"), "Your body is dotted with phosphorescent spots that emit a guiding light and help you communicate. The spots�located primarily on your face, arms, and hands�illuminate a 10-foot radius around you with dim light. You can activate, deactivate, or change the arrangement of lights as an action, which has the concentration trait.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("878f0d0a-504c-4709-8730-2b0ba12b3904"),
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
