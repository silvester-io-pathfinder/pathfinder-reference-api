using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyLore : Template
    {
        public static readonly Guid ID = Guid.Parse("0fad609e-4029-48f6-914e-9608fdfee3e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leshy Lore",
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
            yield return new TextBlock { Id = Guid.Parse("edb17635-663c-40b3-a9f9-4054ce6db54d"), Type = TextBlockType.Text, Text = "You deeply understand your people’s cultural traditions and innate strengths. You gain the trained proficiency rank in Nature and Stealth. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Leshy Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cccd38f0-804c-4d15-bb4d-456821b03251"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
