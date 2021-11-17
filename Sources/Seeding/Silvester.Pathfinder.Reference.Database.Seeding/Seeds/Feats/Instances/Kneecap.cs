using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Kneecap : Template
    {
        public static readonly Guid ID = Guid.Parse("1bf3797d-ca9b-454e-a1be-0c3312c5a6b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kneecap",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f402f2a7-52f4-4940-98b3-632a99b5fb17"), Type = TextBlockType.Text, Text = "You deliver a punishing blow to an enemy’s knee, shin, or other vulnerable anatomy within your reach. Make a (action: Strike) with one of your melee weapons or melee unarmed attacks. This attack doesn’t deal damage. On a hit, the target takes a -10-foot status penalty to its Speed or a -15-foot status penalty on a critical hit. This penalty applies only if the target has a land Speed and depends on legs or other targetable appendages to use its land Speed. As with all penalties to Speed, this can’t reduce a creature’s Speed below 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f69a0fa-504c-4973-8b6f-6b11f5179186"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
