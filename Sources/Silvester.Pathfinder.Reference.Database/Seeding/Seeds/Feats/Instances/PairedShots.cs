using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PairedShots : Template
    {
        public static readonly Guid ID = Guid.Parse("30902f90-8f8c-4006-96bd-8390901bd63f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paired Shots",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46a6975d-a8ae-4cf3-850b-9158e3e469eb"), Type = TextBlockType.Text, Text = "Your shots hit simultaneously. Make two (action: Strikes|Strike), one with each of your two ranged weapons, each using your current multiple attack penalty. Both (action: Strikes|Strike) must have the same target." };
            yield return new TextBlock { Id = Guid.Parse("6c4ce5a3-77ac-4014-9543-7755b7b7ed59"), Type = TextBlockType.Text, Text = "If both attacks hit, combine their damage and then add any applicable effects from both weapons. You add any precision damage, only once, to the attack of your choice. Combine the damage from both (action: Strikes|Strike) and apply resistances and weaknesses only once. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a718b63-d714-4065-939d-85467a710a8a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
