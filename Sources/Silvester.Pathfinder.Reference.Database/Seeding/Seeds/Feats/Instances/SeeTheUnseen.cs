using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeeTheUnseen : Template
    {
        public static readonly Guid ID = Guid.Parse("f829b574-9181-486d-8696-ee04be571b2a");

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
            yield return new TextBlock { Id = Guid.Parse("d23635d4-a17d-428e-a382-383fe6959873"), Type = TextBlockType.Text, Text = "You notice things that others can’t see at all. While you’re adjacent to an undetected creature of your level or lower, it is instead only hidden from you. You only need a successful DC 5 flat check to target a hidden creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2b73511-dd5c-440c-88fe-32c2461bb87f"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
