using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class Empiricism : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Methodology GetMethodology()
        {
            return new Methodology
            {
                Id = ID, 
                Name = "Empiricism",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Everything comes down to data. Calculating statistics, running numbers, and using inductive reasoning allows you to determine the most likely outcome of any scenario, and anything out of place draws your keen attention." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are trained in one Intelligence-based skill of your choice. You gain the That’s Odd investigator feat (page 60), and you gain the Expeditious Inspection free action." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add the option for the methodology skill.
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 5} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 9} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 17} } } };
            yield return new GainSpecificStatSkillFeatEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Intelligence.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 19} } } };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
