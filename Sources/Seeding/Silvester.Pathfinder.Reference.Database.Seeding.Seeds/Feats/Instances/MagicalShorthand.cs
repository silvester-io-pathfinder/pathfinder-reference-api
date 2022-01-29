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
    public class MagicalShorthand : Template
    {
        public static readonly Guid ID = Guid.Parse("df916ea4-15c9-41b5-8f2b-2e05ddd9a323");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Shorthand",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("948b2a96-0f84-4a24-a5bb-e04bd8fa92e1"), Type = TextBlockType.Text, Text = $"Learning spells comes easily to you. If you're an expert in a tradition's associated skill, you take 10 minutes per spell level to learn a spell of that tradition, rather than 1 hour per spell level. If you fail to learn the spell, you can try again after 1 week or after you gain a level, whichever comes first. If you're a master in the tradition's associated skill, learning a spell takes 5 minutes per spell level, and if you're legendary, it takes 1 minute per spell level. You can use downtime to learn and inscribe new spells. This works as if you were using {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} with the tradition's associated skill, but instead of gaining money, you choose a spell available to you to learn and gain a discount on learning it, learning it for free if your earned income equals or exceeds its cost." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("6220a727-20f1-428b-8b98-93f755537967"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("271ab529-8866-4461-9c14-b0c9cd13acd8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("5327608a-3f6e-4ad6-8f2f-89e1842fef3f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("d130daf3-3c29-4d66-a241-bed9a3915399"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("67db0299-5f6d-428a-adfb-447b2603491e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aec73140-7872-4b2e-ace2-4cecefbb6b5b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
