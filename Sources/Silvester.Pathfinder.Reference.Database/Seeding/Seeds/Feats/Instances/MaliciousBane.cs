using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaliciousBane : Template
    {
        public static readonly Guid ID = Guid.Parse("77751f83-1747-455a-961a-d562196e3661");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Malicious Bane",
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
            yield return new TextBlock { Id = Guid.Parse("9b048777-960a-4bdf-855c-88da7a3f770d"), Type = TextBlockType.Text, Text = "Whether your heart is pure or corrupt, you can call forth a malediction upon your foes. You can cast (spell: bane) once per day as a 1st-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31a51643-1b25-4a55-a646-2e30220d0faa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
