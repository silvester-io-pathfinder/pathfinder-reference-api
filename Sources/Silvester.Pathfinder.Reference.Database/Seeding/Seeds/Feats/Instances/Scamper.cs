using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Scamper : Template
    {
        public static readonly Guid ID = Guid.Parse("02daee0a-d701-459d-8a8e-d6a0d764837d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scamper",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59540f64-650b-414e-8209-7952e8178b52"), Type = TextBlockType.Text, Text = "You instinctively know how to flee danger. You (action: Stride) up to your Speed, with a +5-foot status bonus to your Speed, and you gain a +2 circumstance bonus to AC against reactions triggered by this movement. You must end this movement in a space that&#39;s not adjacent to any enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfa789ac-dcab-463a-a543-e143019e2d13"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
