using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DwarvenLore : Template
    {
        public static readonly Guid ID = Guid.Parse("7da8f0bd-a887-4cb1-8ad4-1695a41e1c3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dwarven Lore",
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
            yield return new TextBlock { Id = Guid.Parse("6927d1bb-5349-440e-9f26-edb78a2412d0"), Type = TextBlockType.Text, Text = "You eagerly absorbed the old stories and traditions of your ancestors, your gods, and your people, studying in subjects and techniques passed down for generation upon generation. You gain the trained proficiency rank in Crafting and Religion. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Dwarven Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c89ac375-fc94-4025-be1d-a6805d53b04f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
