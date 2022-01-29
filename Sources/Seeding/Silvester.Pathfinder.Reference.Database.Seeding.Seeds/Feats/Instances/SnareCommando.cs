using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareCommando : Template
    {
        public static readonly Guid ID = Guid.Parse("46b21292-6eb3-4793-9844-02784c114c3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Commando",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature fails or critically fails a save against your snare.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a5795f4-578d-40b5-a27a-9e47c0bdf688"), Type = TextBlockType.Text, Text = $"Your snares are so befuddling that your victims rarely notice you slipping out of sight. If you have expert proficiency in Deception, you can {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)} against the triggering creature. If you have expert proficiency in Intimidation, you can instead {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} the triggering creature. If you have both, choose one of the two effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("42360e5a-e259-4469-955f-385ceed35bc6"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("f7743de3-a8e2-4dcf-9ca0-620ae588027f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("2bb2234d-27d6-42e2-80bf-372008f152c8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("598c2ec5-1984-4462-9dd7-66b08ec7efcc"), Feats.Instances.SnareCrafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e623910-83db-4c40-93e6-222cc66091ea"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
