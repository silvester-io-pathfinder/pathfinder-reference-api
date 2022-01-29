using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpritesSpark : Template
    {
        public static readonly Guid ID = Guid.Parse("e3a468cb-a411-4c7a-98b1-a5e4832fbf7f");

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
            yield return new TextBlock { Id = Guid.Parse("0dce9a4e-6419-4c6d-9078-f28b704f1874"), Type = TextBlockType.Text, Text = $"You can fling a portion of your magic at foes. You gain a ranged unarmed attack in the sling weapon group with a maximum range of 20 feet that deals 1d4 damage. (No ability modifier is added to the damage roll.) The damage type and name of the unarmed attack depends on your heritage, described below; most sprite heritages not presented in this book also use luminous spark. Like other unarmed attacks, you can improve this attack with {ToMarkdownLink<Models.Items.Instances.WornItem>("handwraps of mighty blows", Items.WornItems.Instances.HandwrapsOfMightyBlows.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("360c6abc-fd7f-4634-8bab-67c40f706423"), Type = TextBlockType.Enumeration, Text = $" Draxie: euphoric spark (mental)" };
            yield return new TextBlock { Id = Guid.Parse("0b8460a0-a14c-485b-945a-d323481991a4"), Type = TextBlockType.Enumeration, Text = $" Luminous: luminous spark (fire)" };
            yield return new TextBlock { Id = Guid.Parse("96c7b90d-96a9-4b2d-9a1f-0e2d3dbe3964"), Type = TextBlockType.Enumeration, Text = $" Grig: dissonant note (sonic)" };
            yield return new TextBlock { Id = Guid.Parse("8c3d36aa-a384-47d2-9cbb-81de09e26e67"), Type = TextBlockType.Enumeration, Text = $" Melixie: sting shot (poison)" };
            yield return new TextBlock { Id = Guid.Parse("3dc3773c-b894-4c59-8320-06815948c6ff"), Type = TextBlockType.Enumeration, Text = $" Nyktera: ultrasonic pulse (sonic)" };
            yield return new TextBlock { Id = Guid.Parse("98e42161-7f7d-44ad-989e-4a45b88e5762"), Type = TextBlockType.Enumeration, Text = $" Pixie: pixie dust (mental)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd3b0461-668e-4ac1-970f-c07866b2a112"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
