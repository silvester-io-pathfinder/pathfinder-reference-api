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
    public class JungleCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("90114cb5-52b6-44ac-aa44-5d6193955334");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Jungle Catfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("927ecb6f-74c9-4c21-9acb-618d28ac3465"), Type = TextBlockType.Text, Text = "You�re descended from jungle stalkers and can move swiftly through scrub and underbrush. You ignore difficult terrain from undergrowth, and greater difficult terrain from undergrowth is only difficult terrain for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("61670bde-fe30-4e28-8bd1-5e6a86d8dba1"), "You ignore difficult terrain from undergrowth.");
            builder.Manual(Guid.Parse("4aa5240b-f38e-4151-b7df-c1ede49f9836"), "Greater difficult terrain from undergrowth is only difficult terrain for you.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8570fd4-f1e9-4c45-a971-0e228634bf32"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 10
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
