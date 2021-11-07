using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpringAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("256f67da-0072-49d3-bd4d-6eb161824bef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spring Attack",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e91f36f-02ce-492c-90a7-2cf505450cfe"), Type = TextBlockType.Text, Text = "Springing away from one foe, you (Action: Strike) at another. (Action: Stride) up to your Speed, but you must end that movement within melee reach of a different enemy. At the end of your movement, make a melee (Action: Strike) against an enemy now within reach. You can use Spring Attack while (Action: Burrowing | Burrow), (Action: Climbing | Climb), (Action: Flying | Fly), or (Action: Swimming | Swim) instead of (Action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78bb9f72-b409-4cdc-9004-d35f2c81910e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
