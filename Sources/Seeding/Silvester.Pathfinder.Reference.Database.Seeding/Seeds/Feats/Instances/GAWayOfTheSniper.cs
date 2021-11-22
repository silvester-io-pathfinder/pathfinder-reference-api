using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheSniper : Template
    {
        public static readonly Guid ID = Guid.Parse("5d53be45-e3b7-41a6-8bb5-a9e1fbc07bd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Sniper",
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
            yield return new TextBlock { Id = Guid.Parse("9cf84afc-9440-435a-b1e4-2571f04b5ddb"), Type = TextBlockType.Text, Text = "You practice a style of shooting that seeks to ensure that your first shot is perfectly placed. You keep hidden or at a distance, staying out of the fray and bringing unseen death to your foes." };
            yield return new TextBlock { Id = Guid.Parse("93a2f524-b816-4e1c-a7f8-c29577e964fe"), Type = TextBlockType.Text, Text = "~ Slinger's Reload: (feat: Covered Reload)" };
            yield return new TextBlock { Id = Guid.Parse("3a96f3ae-3755-4e6a-98b0-d4a8702aaa76"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: One Shot, One Kill); __Advanced__ (feat: Vital Shot); __Greater__ (feat: Ghost Shot)" };
            yield return new TextBlock { Id = Guid.Parse("88ff781d-055c-4189-9240-cb7f9efe1c8e"), Type = TextBlockType.Text, Text = "~ Way Skill: Stealth" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea9dd581-9a25-418f-a91f-feacba8bf740"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
