using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HobgoblinLore : Template
    {
        public static readonly Guid ID = Guid.Parse("c699fb0c-c5b0-4750-bbc2-9c4e0db07b85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hobgoblin Lore",
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
            yield return new TextBlock { Id = Guid.Parse("55908333-351a-4558-8ecd-d28401bbb107"), Type = TextBlockType.Text, Text = "You’ve studied traditional hobgoblin exercises and fieldcraft, all of which have a militaristic bent. You become trained in Athletics and Crafting. For each of these skills in which you were already trained, you become trained in a skill of your choice. You also become trained in Hobgoblin Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb122dac-ef00-4996-a6fe-01a8f6bd9064"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
