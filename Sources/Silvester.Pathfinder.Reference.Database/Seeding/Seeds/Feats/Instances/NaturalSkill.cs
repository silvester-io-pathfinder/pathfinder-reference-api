using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalSkill : Template
    {
        public static readonly Guid ID = Guid.Parse("46e46c00-7dcd-4ffb-81cf-87c7953e8c90");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Skill",
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
            yield return new TextBlock { Id = Guid.Parse("16955cd7-b5e0-4daf-a8df-03b06a7ade7d"), Type = TextBlockType.Text, Text = "Your ingenuity allows you to learn a wide variety of skills. You gain the trained proficiency rank in two skills of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1d17782-52ff-4e39-a0e7-5c528ca66db7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
