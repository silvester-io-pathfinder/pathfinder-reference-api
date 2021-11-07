using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("e31710f1-4f81-4fbe-866d-2ab836305d5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Death",
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
            yield return new TextBlock { Id = Guid.Parse("12fff268-3c4b-4ef2-9f62-e305e9387292"), Type = TextBlockType.Text, Text = "~ Lesson Type: Major" };
            yield return new TextBlock { Id = Guid.Parse("a7e42c76-b627-456d-9a84-8318796f4bb7"), Type = TextBlockType.Text, Text = "You gain the (spell: curse of death) hex, and your familiar learns (spell: raise dead)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c8ff11c-f87f-4ae1-a5ac-29d03166aa03"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
