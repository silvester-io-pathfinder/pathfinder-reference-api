using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EyeForTreasure : Template
    {
        public static readonly Guid ID = Guid.Parse("462df43b-809b-4876-b184-7da8010f7ce9");

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
            yield return new TextBlock { Id = Guid.Parse("daf41930-7df5-41f5-a439-835eb36ac9a5"), Type = TextBlockType.Text, Text = "You know good artisanship when you see it and can wax poetic about crafting techniques and forms. You become trained in Crafting and gain a +1 circumstance bonus on all Crafting checks made to (action: Recall Knowledge). If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. In addition, you gain the (feat: Crafter’s Appraisal) skill feat, enabling you to identify magic items using the Crafting skill." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed1aa02a-9a25-432f-96fb-a0a18f605fe4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
