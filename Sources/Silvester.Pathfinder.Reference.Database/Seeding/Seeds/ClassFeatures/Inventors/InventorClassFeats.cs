using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InventorClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Inventor Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level, you gain an inventor class feat. Some features and feats use an assortment of gizmos you keep on your person. For simplicity, these are left abstract, but if you are deprived of your gear for some reason, you might lose access to many feats and features, subject to GM discretion." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Inventor.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
