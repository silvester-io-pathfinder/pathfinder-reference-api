using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("87e36028-6c2c-45d3-9273-b4b336f651e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Weapon",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You finish Casting a Spell using one of your divine spell slots on your turn.",
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("237a8c15-f835-4925-8067-0bbb62d1dc5b"), Type = TextBlockType.Text, Text = "You siphon residual spell energy into a weapon you’re wielding. Until the end of your turn, the weapon deals an additional 1d4 force damage. You can instead deal an additional 1d6 damage of an alignment type that matches one of your deity’s alignment components. As usual for aligned damage, this can damage only creatures of the opposite alignment." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1885612-8b26-4df4-805b-d281ef193a71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
