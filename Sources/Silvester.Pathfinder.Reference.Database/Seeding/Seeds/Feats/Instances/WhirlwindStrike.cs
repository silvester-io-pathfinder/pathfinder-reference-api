using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("d54281cd-46bf-4f4e-9462-80c4c8e2632b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b193d891-3148-41d6-b588-d9cb0ed7f18a"), Type = TextBlockType.Text, Text = "You attack all nearby adversaries. Make a melee (Action: Strike) against each enemy within your melee reach. Each attack counts toward your multiple attack penalty, but do not increase your penalty until you have made all your attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7af5b66f-a09a-452f-9239-82c2bf06ed15"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
