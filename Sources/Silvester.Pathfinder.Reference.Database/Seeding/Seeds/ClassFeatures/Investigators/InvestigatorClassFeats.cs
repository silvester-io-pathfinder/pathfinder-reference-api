using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class InvestigatorClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Investigator Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level, you gain an investigator class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse(""), Guid.Parse(""), Classes.Instances.Investigator.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
