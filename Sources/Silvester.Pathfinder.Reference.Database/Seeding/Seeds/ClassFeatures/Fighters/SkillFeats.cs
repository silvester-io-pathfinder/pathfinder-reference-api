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
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2, 
                Name = "Skill Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
