using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatfolkLore : Template
    {
        public static readonly Guid ID = Guid.Parse("d641ead9-7462-4671-9955-b0cf9c316c94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratfolk Lore",
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
            yield return new TextBlock { Id = Guid.Parse("2a03e4d4-b191-45f9-8f11-8f00385b04d6"), Type = TextBlockType.Text, Text = "Years of experience among ratfolk communities have made you nimble, and you&#39;ve learned to run and hide when enemies threaten. You gain the trained proficiency rank in Acrobatics and Stealth. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Ratfolk Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("911bb0ce-baaa-4260-a7a4-36a54dec7b4c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
