using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("b781cd79-b153-4cb3-9acd-59b439588ce7");

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
            yield return new TextBlock { Id = Guid.Parse("c7e1893e-88fa-4789-a273-8ef90b02b387"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("e133d653-9d29-4077-9907-627b7b4d00d9"), Guid.Parse("783c579e-0d7c-4a21-a8f1-433b9f0df5ae"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("ac63b79f-16f9-46f4-895b-930a18ce0cd4"), Guid.Parse("d1fc63ab-2259-4183-b330-5831c3bebe52"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("57a83270-526b-4f95-b1e9-8fa0a1790889"), Guid.Parse("9cf61caf-b9cb-4433-8d33-721976acb39d"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("62d0bd9a-fc79-4c53-b384-360db6edf304"), Guid.Parse("37148348-585d-42cf-ab57-e91007d11378"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("563f89c0-31b8-4173-98c3-2601f962e5d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
