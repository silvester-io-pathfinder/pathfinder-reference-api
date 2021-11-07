using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SongbirdStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Songbird Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You descend from a talented line of strix storytellers. From the highest mountains and purest landscapes where your lungs fill with glorious clean air, you trill, whistle, and croon sweet songs. While natural sounds make you predisposed to sing, voices make you predisposed to mimicry. You receive a +1 circumstance bonus on Deception checks to Impersonate a mimicked voice, where the sound of the voice is the only factor; if you are a master in Deception, you gain a +2 circumstance bonus instead. You also gain a +1 circumstance bonus on Performance checks to sing; if you are a master in Performance, you gain a +2 circumstance bonus instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Deception.ID, SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "Only applies to impersonating a mimicked voice, where the sound of the voice is the only factor.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Deception.ID, SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "Only applies to impersonating a mimicked voice, where the sound of the voice is the only factor.")
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
                });

            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse(""), Skills.Instances.Performance.ID, bonus: 1, addendum: "Only applies to singing.");
            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse(""), Skills.Instances.Performance.ID, bonus: 1, addendum: "Only applies to singing.")
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, Skills.Instances.Performance.ID);
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
