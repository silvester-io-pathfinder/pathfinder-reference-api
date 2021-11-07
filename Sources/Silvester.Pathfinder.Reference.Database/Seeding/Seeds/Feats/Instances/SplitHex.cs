using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplitHex : Template
    {
        public static readonly Guid ID = Guid.Parse("71a36250-fbad-4c14-8dee-9eea6821af77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Split Hex",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ebbbe0f8-6b67-41ef-aab5-0e6547bbf6b2"), Type = TextBlockType.Text, Text = "You siphon some of the power from an offensive hex you cast to direct it at a second target as well. If the next action you use is to (activity: Cast a Spell) to cast a harmful (trait: hex) with a single target, reduce its level by 2 (making it 2 levels lower than the maximum spell level you can cast). If you do, you can select a second target for that (trait: hex) to affect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4fb8d1d-9070-4c58-8fce-4255e337b01f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
