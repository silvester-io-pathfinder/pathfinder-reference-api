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
    public class DeepFetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Deep Fetchling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your predecessors dwelled in the Shadow Plane's deepest, most treacherous regions. You might cast a denser shadow, have a slower pulse, or find comfort in the embrace of darkness. You gain cold or negative resistance equal to half your level (minimum 1), chosen when you gain this heritage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 85
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Fetchling.ID;
        }
    }
}
