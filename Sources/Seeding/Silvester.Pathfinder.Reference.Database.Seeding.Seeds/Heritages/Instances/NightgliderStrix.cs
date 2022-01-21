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
    public class NightgliderStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("de4e88d1-0a22-4b0e-924e-38c363e316f1");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Nightglider Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a31cc703-2300-40db-8f58-f37b608cef73"), Type = TextBlockType.Text, Text = "You are a dedicated nocturnal avian, keeping watch and predating in the most lightless environments. You gain darkvision." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("f9111e23-1b0d-4b40-ad34-4735f5785ebd"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("101875fc-616f-497e-ac07-04fa7dbb1201"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
