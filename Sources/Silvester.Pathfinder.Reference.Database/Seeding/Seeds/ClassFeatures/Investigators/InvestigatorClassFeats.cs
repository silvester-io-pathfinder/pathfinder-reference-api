using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 2 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 4 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 6 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 8 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 10 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 12 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 14 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 16 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 18 } } } };
            yield return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Investigator.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 20 } } } };
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
