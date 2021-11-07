using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnadiVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("f24c019a-ea81-4682-b824-d85fed699322");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anadi Venom",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "a number of times per day equal to your level"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1935bfa3-8f38-4ea6-a7c6-8d4994a1cbfe"), Type = TextBlockType.Text, Text = "You envenom your fangs. If the next fangs (action: Strike) you make before the end of your turn hits and deals damage, the (action: Strike) deals an additional 1d6 poison damage. On a critical failure, the poison is wasted as normal. At 12th level, this poison damage increases to 2d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d820113-e33f-4484-93fa-2c5fff6f3ccd"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
