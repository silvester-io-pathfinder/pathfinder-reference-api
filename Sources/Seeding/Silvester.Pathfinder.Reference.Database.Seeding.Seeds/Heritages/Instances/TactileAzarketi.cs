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
    public class TactileAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("bf0cfba4-5cee-429a-87fd-16ab8cba6384");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Tactile Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f203b5a4-0295-4faa-bbbc-191f8c8ba7aa"), Type = TextBlockType.Text, Text = "Your skin can detect the slightest changes in ocean currents. You gain imprecise wavesense with a range of 30 feet, allowing you to sense motion in the water around you. You also gain a +1 circumstance bonus to Survival checks to Sense Direction in aquatic environments." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("87ffbbcd-b787-4865-911d-8f4502b5acb9"), Senses.Instances.Wavesense.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("814ad15f-7190-4597-b05b-7d80a6b7e481"), Skills.Instances.Survival.ID, SkillActions.Instances.SenseDirection.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08c557aa-0c42-4ec4-9dd4-dfe996415dce"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
