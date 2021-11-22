using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TideHardened : Template
    {
        public static readonly Guid ID = Guid.Parse("d74837c4-5c9d-4f91-9ef8-8e149fec3a20");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tide-Hardened",
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
            yield return new TextBlock { Id = Guid.Parse("968896d8-2364-4d6c-ae5d-39909c16d702"), Type = TextBlockType.Text, Text = "You're at home in the unpredictable tides. You gain a +1 circumstance bonus to saves against (trait: cold) and (trait: water) effects. If you roll a success on a save against a (trait: cold) or (trait: water) effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42614aaf-3da7-45e1-a8ce-d83329f2833d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
