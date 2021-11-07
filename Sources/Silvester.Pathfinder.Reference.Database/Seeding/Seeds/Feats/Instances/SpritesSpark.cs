using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpritesSpark : Template
    {
        public static readonly Guid ID = Guid.Parse("bafd2fd0-da53-4549-826c-ef070f9fc7b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sprite's Spark",
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
            yield return new TextBlock { Id = Guid.Parse("3175cc7c-2d4f-4738-bc44-8ad24093f7a7"), Type = TextBlockType.Text, Text = "You can fling a portion of your magic at foes. You gain a ranged unarmed attack in the sling weapon group with a maximum range of 20 feet that deals 1d4 damage. (No ability modifier is added to the damage roll.) The damage type and name of the unarmed attack depends on your heritage, described below; most sprite heritages not presented in this book also use luminous spark. Like other unarmed attacks, you can improve this attack with (item: handwraps of mighty blows)." };
            yield return new TextBlock { Id = Guid.Parse("3a38e8bb-7754-45c5-85ef-d07eee0c48a4"), Type = TextBlockType.Enumeration, Text = " Draxie: euphoric spark (mental)" };
            yield return new TextBlock { Id = Guid.Parse("6f12c7da-caff-4868-b64c-314aec5ed605"), Type = TextBlockType.Enumeration, Text = " Luminous: luminous spark (fire)" };
            yield return new TextBlock { Id = Guid.Parse("a62baa8e-8388-4d75-ae0f-e4d996770c4b"), Type = TextBlockType.Enumeration, Text = " Grig: dissonant note (sonic)" };
            yield return new TextBlock { Id = Guid.Parse("e5555b1f-59f3-4cc1-8f44-61e6ad9f741e"), Type = TextBlockType.Enumeration, Text = " Melixie: sting shot (poison)" };
            yield return new TextBlock { Id = Guid.Parse("7465ee60-df63-47e6-a4fe-600913e36dff"), Type = TextBlockType.Enumeration, Text = " Nyktera: ultrasonic pulse (sonic)" };
            yield return new TextBlock { Id = Guid.Parse("7db9ab6c-89d0-4a6d-a11e-cd18e56ad3d0"), Type = TextBlockType.Enumeration, Text = " Pixie: pixie dust (mental)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cd79307-67f1-4be6-a428-4623ddd49bca"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
