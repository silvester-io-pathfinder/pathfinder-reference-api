using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CharmingLiar : Template
    {
        public static readonly Guid ID = Guid.Parse("44f93c9d-03b8-46af-b242-1a8be368dbf7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charming Liar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cd4fc63-aa99-4368-ba87-bcc9d2a260ca"), Type = TextBlockType.Text, Text = "Your charm allows you to win over those you lie to. When you get a critical success using the (action: Lie) action, the target’s attitude toward you improves by one step, as though you’d succeeded at using Diplomacy to (action: Make an Impression). This works only once per conversation, and if you critically succeed against multiple targets using the same result, you choose one creature’s attitude to improve. You must be lying to impart seemingly important information, inflate your status, or ingratiate yourself, which trivial or irrelevant lies can’t achieve." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("703d066a-580d-4ed1-b171-1b3f04dbfdc5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec88a904-2bab-4048-8dcb-e70a728cc578"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
