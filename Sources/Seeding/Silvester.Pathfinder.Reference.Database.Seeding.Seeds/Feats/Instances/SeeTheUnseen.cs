using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeeTheUnseen : Template
    {
        public static readonly Guid ID = Guid.Parse("fe327ced-072f-49f9-a835-837ffce85324");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "See the Unseen",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5700ccc5-c690-4d6e-b1da-d59e07a32478"), Type = TextBlockType.Text, Text = $"You notice things that others can't see at all. While you're adjacent to an undetected creature of your level or lower, it is instead only hidden from you. You only need a successful DC 5 flat check to target a hidden creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2001052-bb92-4340-97a7-f9f92b47be39"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
