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
        public static readonly Guid ID = Guid.Parse("c5d17214-0139-4792-961f-3fdb4cdd7fd5");

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
            yield return new TextBlock { Id = Guid.Parse("fc2bcd74-ca5c-4335-9ba4-8e4cf90dd5f0"), Type = TextBlockType.Text, Text = "Your ancestors' exposure to the Shadow Plane wrought great physical changes. Your hair or skin sometimes appears insubstantial, and you're slighter and more agile than other fetchlings. You're Small instead of Medium. You gain the trained proficiency rank in Acrobatics, the Quick Squeeze skill feat, and a +1 circumstance bonus to Acrobatics checks to Tumble Through. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestrySize(Guid.Parse("1ccce204-dff2-4a87-9752-39f4abf7322b"), AncestrySizes.Instances.Medium.ID);
            builder.GainSpecificFeat(Guid.Parse("f7a814af-3112-4dbb-b5d9-69642f8197a2"), Feats.Instances.QuickSqueeze.ID);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("0a9acc6f-ec16-4938-9a6c-592983bf2691"), Skills.Instances.Acrobatics.ID, SkillActions.Instances.TumbleThrough.ID, bonus: 1);
            
            builder.AddOr(Guid.Parse("2876e1df-baec-4f2d-a331-d0bdfdb6b2ad"), or =>
            {
                builder.GainSpecificSkillProficiency(Guid.Parse("c94e091d-a3be-47a6-aee4-1b7fbc4b2a56"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                builder.GainAnySkillProficiency(Guid.Parse("f948684f-9cc8-42dc-b8b2-736926e07255"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("63a8f554-b8fc-4a41-b266-da3327eafc61"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("d27800f0-02cd-4b58-8bc4-aa9ccfccd9b9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0aefec23-355b-4ca9-b1f5-eb95575090f1"),
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
