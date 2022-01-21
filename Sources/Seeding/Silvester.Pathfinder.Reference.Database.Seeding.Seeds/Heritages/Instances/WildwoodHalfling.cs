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
    public class WildwoodHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("0b36fe08-7970-45a3-a816-05d187ae1709");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wildwood Halfling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("155078da-980a-4f8e-8b51-b2b6138fe918"), Type = TextBlockType.Text, Text = "You hail from deep in a jungle or forest, and you've learned how to use your small size to wriggle through undergrowth, vines, and other obstacles. You ignore difficult terrain from trees, foliage, and undergrowth." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("3dad97ef-6973-47ec-b9ee-9d14010b3edd"), "You ignore difficult terrain from trees, foliage, and undergrowth.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92c621a0-e150-42d0-93fd-21305b5f86c6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 52
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
