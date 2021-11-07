using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MutagenicFlashback : Template
    {
        public static readonly Guid ID = Guid.Parse("4b1654d5-a2ac-4152-98be-1c7dff4e086c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mutagenic Flashback",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("337e79a6-e48f-4f11-a974-c4f060e4d1a4"), Type = TextBlockType.Text, Text = "You experience a brief resurgence of a mutagen. Choose one mutagen you’ve consumed since your last daily preparations. You gain the effects of that mutagen for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2715ff70-6def-48b3-913a-a00f6ac0f070"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
