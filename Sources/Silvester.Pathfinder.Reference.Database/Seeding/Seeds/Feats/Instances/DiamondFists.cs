using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiamondFists : Template
    {
        public static readonly Guid ID = Guid.Parse("00a5411e-86b6-47d5-b574-a67f6901c268");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diamond Fists",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86b2c002-dd9e-487e-ad1d-34db7590e243"), Type = TextBlockType.Text, Text = "Your body hardens as you combine your attacks, making your finishing blows more damaging. Your unarmed attacks gain the (trait: forceful) trait. Any that already had this trait instead increase their weapon damage dice by one step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c0915a3-756e-4939-8791-9f46693a8fa8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
