using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AggressiveBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("24b188d9-0775-43b5-a74d-aab2c485246e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aggressive Block",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use the Shield Block reaction, and the opponent that triggered Shield Block is adjacent to you and is your size or smaller.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7bdaee0b-35cc-44ab-b95b-c1f9fa29f33d"), Type = TextBlockType.Text, Text = "You push back as you block the attack, knocking your foe away or off balance. You use your shield to push the triggering creature, either automatically Shoving it 5 feet or causing it to become flat-footed until the start of your next turn. The triggering creature chooses whether to be moved or become flat-footed. If it chooses to be moved, you choose the direction. If the (Action: Shove) would cause it to hit a solid object, enter a square of difficult terrain, or enter another creature’s space, it must become flat-footed instead of being moved." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9eb29fb-7477-4c21-9c5d-e5a9c29372fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
