using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("9d36b85e-c53a-43ed-a1ff-ef9f3093df72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monster Hunter",
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
            yield return new TextBlock { Id = Guid.Parse("521c3d4e-27d6-4387-98d7-792362d72e88"), Type = TextBlockType.Text, Text = $"You swiftly assess your prey and apply what you know. As part of the action used to {ToMarkdownLink<Models.Entities.Feat>("Hunt your Prey", Feats.Instances.HuntPrey.ID)}, you can attempt a check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about your prey." };
            yield return new TextBlock { Id = Guid.Parse("66926741-460a-4c60-adbf-6b1a5d57791b"), Type = TextBlockType.Text, Text = $"When you critically succeed at identifying your hunted prey with {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, you note a weakness in the creature's defenses. You and allies you tell may gain a +1 circumstance bonus to your next attack roll against that prey. You can give bonuses from Monster Hunter only once per day against a particular creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da949109-26e0-406b-929d-827728548cc7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
