using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WispFetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wisp Fetchling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors' exposure to the Shadow Plane wrought great physical changes. Your hair or skin sometimes appears insubstantial, and you're slighter and more agile than other fetchlings. You're Small instead of Medium. You gain the trained proficiency rank in Acrobatics, the Quick Squeeze skill feat, and a +1 circumstance bonus to Acrobatics checks to Tumble Through. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse(""), AncestrySizes.Instances.Medium.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.QuickSqueeze.ID);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Acrobatics.ID, SkillActions.Instances.TumbleThrough.ID, bonus: 1);
            
            builder.AddOr(Guid.Parse(""), or =>
            {
                builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                builder.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 85
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Fetchling.ID;
        }
    }
}
