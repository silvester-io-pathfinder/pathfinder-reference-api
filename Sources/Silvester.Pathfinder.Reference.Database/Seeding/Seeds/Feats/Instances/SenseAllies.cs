using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("a3bf8d78-d2e5-4551-bc2b-52b69eee662a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Allies",
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
            yield return new TextBlock { Id = Guid.Parse("d7ee0bfa-23bb-46e3-a73c-5b857430195d"), Type = TextBlockType.Text, Text = "Like many humans raised in a close-knit community, you have always been strongly attuned to the presence of others. Willing allies that you are aware of within 60 feet that would otherwise be undetected by you are instead hidden from you. The flat check for you to target willing allies within 60 feet that are hidden from you is 5 instead of 11." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73f818f8-59a2-47ec-99fc-20b522b8dd36"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
