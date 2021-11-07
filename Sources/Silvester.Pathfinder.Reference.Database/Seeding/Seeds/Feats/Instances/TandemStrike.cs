using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TandemStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("85698ba4-ca20-4dda-a9f4-4e39732c7173");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tandem Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("270e1a7a-5bfa-4bed-9d55-b1961ab3e32e"), Type = TextBlockType.Text, Text = "You and your eidolon each attack, seamlessly targeting the same foe without interfering with each other’s movements. Your eidolon makes a melee (action: Strike), and then you make a melee (action: Strike) against the same creature. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after both attacks have been made." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38a5ad0f-f7c2-4219-a5dc-381718d51ac4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
