using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeForTreasure : Template
    {
        public static readonly Guid ID = Guid.Parse("7fcd002f-82e1-4515-bd27-115dbe0b1c38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye for Treasure",
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
            yield return new TextBlock { Id = Guid.Parse("000b103c-5555-4a02-a3c9-39d946da63b3"), Type = TextBlockType.Text, Text = "You know good artisanship when you see it and can wax poetic about crafting techniques and forms. You become trained in Crafting and gain a +1 circumstance bonus on all Crafting checks made to (action: Recall Knowledge). If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. In addition, you gain the (feat: Crafter’s Appraisal) skill feat, enabling you to identify magic items using the Crafting skill." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9942ebaf-0df5-4f68-b9da-23f2270a8d8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
