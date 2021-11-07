using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormOfTheBat : Template
    {
        public static readonly Guid ID = Guid.Parse("ff09b17d-0fef-48ec-a80d-709c3825f035");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form of the Bat",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c682156-4de2-47af-8f03-2e2b9b54747d"), Type = TextBlockType.Text, Text = "You can transform into a harmless bat. You gain the effects of a 4th-level (spell: pest form), except you always transform into a bat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e87d71dc-b0ab-48a7-9844-8192a88c9075"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
