using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("0b7236dc-0eef-416d-b949-a637a4f41a92");

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
            yield return new TextBlock { Id = Guid.Parse("33e3e0c8-25ea-4278-b6aa-559de94b537c"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("244f8bb8-625a-4883-b2a5-595dd2a24337"), Guid.Parse("cf6735aa-d83a-401f-b9ca-9d7ba6dba0a7"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("19c5b4c4-67cb-414a-a73c-6670ab01bb28"), Guid.Parse("19676789-9121-4c52-9168-4ece1b111ba2"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("1359f760-0172-44a3-ba94-f5163682d99b"), Guid.Parse("013c233f-1fd8-4d2d-88d9-9511219495ee"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("22fe1a4f-b3a2-4a62-aa59-429a6c005868"), Guid.Parse("c7728524-2003-4fc0-8549-b9e9112e811c"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47cc7635-afe7-4e34-852b-6382d0663902"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
