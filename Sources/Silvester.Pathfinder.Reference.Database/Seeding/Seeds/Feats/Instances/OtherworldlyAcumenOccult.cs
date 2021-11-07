using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumenOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("2d0497db-10cc-4062-b4f0-9c80371898bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Acumen - Occult",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a0c299b-10b4-46a4-b38a-37ecc2b7f20b"), Type = TextBlockType.Text, Text = "Choose one common 2nd-level spell from the occult tradition." };
            yield return new TextBlock { Id = Guid.Parse("8f8e468f-bf1c-4f9c-b8c0-2f0ec20be5fb"), Type = TextBlockType.Text, Text = "You can cast that spell as an innate spell once per day. Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fbe9ece-8213-4fa2-a0f2-147456438338"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
