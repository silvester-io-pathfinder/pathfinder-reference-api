using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Called : Template
    {
        public static readonly Guid ID = Guid.Parse("ab799d79-ba2d-4e25-a0ce-c70f80fcf675");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Called",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("976a7191-aab4-4d71-aa49-e7d27f5c0eb0"), Type = TextBlockType.Text, Text = "You have heard the Call, and in constantly resisting that persistent demand, you&#39;ve developed a mental bulwark against effects that would target your mind. You gain a +1 circumstance bonus to Will saving throws against (trait: mental) effects. If you roll a success on your saving throw against a (trait: mental) effect that would make you controlled, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a00ab32b-c0f4-4aaa-b719-2c0f6caa29a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
