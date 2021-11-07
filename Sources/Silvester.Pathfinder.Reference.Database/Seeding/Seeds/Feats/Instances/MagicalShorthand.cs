using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalShorthand : Template
    {
        public static readonly Guid ID = Guid.Parse("dbd06968-37f1-45ab-bd20-4e1e5b1bba01");

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
            yield return new TextBlock { Id = Guid.Parse("80de6dcb-3433-4892-87c9-a4a4df5f605e"), Type = TextBlockType.Text, Text = "Learning spells comes easily to you. If you’re an expert in a tradition’s associated skill, you take 10 minutes per spell level to learn a spell of that tradition, rather than 1 hour per spell level. If you fail to learn the spell, you can try again after 1 week or after you gain a level, whichever comes first. If you’re a master in the tradition’s associated skill, learning a spell takes 5 minutes per spell level, and if you’re legendary, it takes 1 minute per spell level. You can use downtime to learn and inscribe new spells. This works as if you were using (action: Earn Income) with the tradition’s associated skill, but instead of gaining money, you choose a spell available to you to learn and gain a discount on learning it, learning it for free if your earned income equals or exceeds its cost." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c96190e8-9d94-445b-af84-9c39597cce85"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("aefe26ba-17d3-42cc-967e-6712cdf8e3c6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("55c13008-ccdd-4dbd-89a8-5309526856cb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("42fd7b47-0e85-4341-b4d7-937cc16d141e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("dd8e2a69-5093-4c7b-ac4b-ed18f4062a53"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c94a650-6141-4217-ace3-0621fcdfdc93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
