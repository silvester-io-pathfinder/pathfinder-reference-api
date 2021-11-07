using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NimbleHooves : Template
    {
        public static readonly Guid ID = Guid.Parse("26be45cd-3687-40f2-86b6-ead260a5059b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Hooves",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "The Speed increase from this feat isn't cumulative with any Speed increase from your ancestry feats (such as (feat: Nimble Elf)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58dddc00-8c77-4966-8ae0-0ecd1e29a051"), Type = TextBlockType.Text, Text = "Your legs end in hooves rather than feet, with joints and tendons that allow you to move with great haste. Your Speed increases by 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6044fe5-7c8b-484f-876f-714c556db2a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
