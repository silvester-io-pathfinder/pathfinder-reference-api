using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsciousSpellSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("1c4b9916-10c6-4cc3-879f-486c28f276a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conscious Spell Specialization",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7689e184-d93c-4cdd-9f14-f06fd7e5cc2a"), Type = TextBlockType.Text, Text = "Your practice with the spells of your conscious mind allows you to cast them even more than normal. You gain an additional spell slot of 1st, 2nd, 3rd, and 4th levels. You can use these spell slots to cast only spells granted by your conscious mind." };
            yield return new TextBlock { Id = Guid.Parse("21609711-2ece-4e45-b436-68cd552af89a"), Type = TextBlockType.Text, Text = "At 18th level, you also gain an additional 5th-level spell slot with the same restrictions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff6727fe-3bda-4d8e-9f57-0561e7c22468"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
