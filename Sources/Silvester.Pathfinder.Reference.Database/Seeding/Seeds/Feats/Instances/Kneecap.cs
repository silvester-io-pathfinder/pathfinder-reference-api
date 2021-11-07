using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Kneecap : Template
    {
        public static readonly Guid ID = Guid.Parse("52eda890-996b-4b96-a67d-a2831e69778d");

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
            yield return new TextBlock { Id = Guid.Parse("e7616c4f-9b2a-450f-b24e-69c4f2bfdb72"), Type = TextBlockType.Text, Text = "You deliver a punishing blow to an enemy’s knee, shin, or other vulnerable anatomy within your reach. Make a (action: Strike) with one of your melee weapons or melee unarmed attacks. This attack doesn’t deal damage. On a hit, the target takes a -10-foot status penalty to its Speed or a -15-foot status penalty on a critical hit. This penalty applies only if the target has a land Speed and depends on legs or other targetable appendages to use its land Speed. As with all penalties to Speed, this can’t reduce a creature’s Speed below 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e8da0a-9c05-4eaf-bfd3-88b0e502bfdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
