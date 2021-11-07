using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spelunker : Template
    {
        public static readonly Guid ID = Guid.Parse("44bc604c-201b-43d0-8ac9-a086010d756e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spelunker",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c539cbef-a1c2-420a-ad78-f8da47f484e8"), Type = TextBlockType.Text, Text = "Living underground, you have learned to find your way without landmarks or even solid ground. If you roll a success on an Survival check to (action: Sense Direction) or an Athletics check to (action: Climb), you get a critical success instead. You’re not flat-footed when you attempt to (action: Climb)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4c821b2-7857-48fb-9751-56e15a8102a5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
