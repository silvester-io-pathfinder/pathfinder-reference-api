using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Shred : Template
    {
        public static readonly Guid ID = Guid.Parse("848acb57-d875-42ee-ab27-fc36fa52546a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shred",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40fb8b30-3efb-4cab-b1c7-b65a5bbfc263"), Type = TextBlockType.Text, Text = $"The shark viciously rips into the wound, dealing additional damage. The target of the shark's {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} takes 1d8 slashing damage (2d8 for a mature shark or 3d8 for a specialized companion)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45040db5-12b2-4ff1-8a5f-b4d86128f15e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
