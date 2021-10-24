using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add the option for the methodology skill.
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 3);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 5);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 7);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 9);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 11);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 13);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 15);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 17);
            builder.GainSpecificStatSkillFeat(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, requiredLevel: 19);
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
