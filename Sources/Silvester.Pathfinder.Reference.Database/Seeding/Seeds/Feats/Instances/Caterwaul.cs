using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Caterwaul : Template
    {
        public static readonly Guid ID = Guid.Parse("db8ea3b0-3b1b-43b9-95d0-8fb68a030f96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Caterwaul",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet would be reduced to 0 HP but not immediately killed.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a26daaec-f514-4a0a-883d-e6dbb35d8c8a"), Type = TextBlockType.Text, Text = "You give a daring yowl in the face of adversity, calling your companion back from the brink of unconsciousness. Your ally isn&#39;t knocked out and remains at 1 Hit Point. Your ally&#39;s wounded condition still increases by 1 as though they had been dying and recovered." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f90ad542-d9a1-47a4-a2c7-6b14b036a589"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
