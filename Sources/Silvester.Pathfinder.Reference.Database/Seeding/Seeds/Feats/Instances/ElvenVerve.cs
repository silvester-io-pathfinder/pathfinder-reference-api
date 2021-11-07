using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenVerve : Template
    {
        public static readonly Guid ID = Guid.Parse("0860fdfb-7e3c-41fc-b328-d94c9af5509d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elven Verve",
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
            yield return new TextBlock { Id = Guid.Parse("37d5f6b6-df9b-4ef7-9613-4916b9dfc50f"), Type = TextBlockType.Text, Text = "While all elves are immune to the paralyzing touch of ghouls, you can shake off flesh-numbing magic of all kinds. You gain a +1 circumstance bonus to saves against effects that would impose the immobilized, paralyzed, or slowed conditions. When you would be immobilized, paralyzed, or slowed for at least 2 rounds, reduce that duration by 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16359bfa-02f8-4e6b-935b-9963c243cd1b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
