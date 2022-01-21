using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("e0032d0a-2a86-43cf-b18c-9847bdd8af69");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ancestry Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fd84b118-0c3c-4fc4-99e1-70711fd8da0c"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("5ba5e9d1-079f-4d94-a97c-ee0096647513"), Guid.Parse("85a0d175-ec5e-40ca-978e-ed1c1168eba0"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("3db2e5dd-640e-4cf2-a972-319a94a2811a"), Guid.Parse("c602512f-340d-4249-9f42-52c7a8feb962"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("ad18d403-e367-4020-8dce-3ba91638e842"), Guid.Parse("6a0dae32-3437-4ba3-83ec-6f09f10cb78a"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("a1ede344-19ff-4281-897e-8b341e013580"), Guid.Parse("a6768659-299b-4ba6-a7cf-3601ee406b39"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca197e2f-870a-4118-8168-dfc1d4331a29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
