using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudiousMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("9a61a60b-cc5b-4fb4-b0a7-04524cd9cccd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Studious Magic",
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
            yield return new TextBlock { Id = Guid.Parse("f9a74d38-a119-4106-9ec8-d909a33ec6ae"), Type = TextBlockType.Text, Text = "You’ve taken an interest in anadi arcane traditions. Choose one cantrip from the arcane spell list. You can cast this spell as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a51227aa-ff81-403b-b797-03be28692351"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
