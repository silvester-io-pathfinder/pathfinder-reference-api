using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("270791bd-a081-45aa-aeb4-ed11f96f7d58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Guidance",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61f521e1-b70d-4dce-8b2b-2a18bb2eb281"), Type = TextBlockType.Text, Text = "You’re so immersed in divine scripture that you find meaning and guidance in your texts in any situation. Spend 10 minutes Deciphering Writing on religious scriptures of your deity or philosophy while thinking about a particular problem or conundrum you face, and then attempt a Religion check (DC determined by the GM). If you succeed, you unearth a relevant passage, parable, or aphorism that can help you move forward or change your thinking to help solve your conundrum. For example, the GM might provide you with a cryptic poem or hint that can guide you to the next step of solving your problem." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("395a2402-53a6-48d8-aa55-fd4f54ac067d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e599529b-d6a7-4cf5-9770-4461433b4a9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
