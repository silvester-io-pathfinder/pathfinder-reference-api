using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("f2ba48d8-678a-47e0-a4fd-227afe10c161");

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
            yield return new TextBlock { Id = Guid.Parse("9a06a6fc-d877-4adb-ad19-93e1a6fee220"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("90d9278d-f4da-49d1-a1fd-dbf2bdd95465"), Guid.Parse("09779fb8-3c8b-4d17-a986-0dcd8e83eda2"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("4bb37514-9fba-48b2-9aca-cd9fd4400534"), Guid.Parse("e5b96d29-865c-4fce-ae0d-f9bc21c8d47c"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("c89bfa28-7622-47e1-9bdf-de6aefeb7889"), Guid.Parse("a1f0112f-d87f-4ce0-bbfe-0b538142bfa2"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("e4dd7b19-6aed-4b56-9a5d-be0c3cda7158"), Guid.Parse("739c832a-67ba-42f7-8163-b4a835b8d5a6"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d441419-a4d8-4dae-b11a-f2f2120c8bad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
