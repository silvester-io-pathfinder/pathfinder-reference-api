using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TandemStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b5a577bf-66e2-4ca1-94af-abdac129bacd");

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
            yield return new TextBlock { Id = Guid.Parse("b77416e8-c525-4298-a7c0-b1452396e0ab"), Type = TextBlockType.Text, Text = "You and your eidolon each attack, seamlessly targeting the same foe without interfering with each other’s movements. Your eidolon makes a melee (action: Strike), and then you make a melee (action: Strike) against the same creature. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after both attacks have been made." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a0e9556-9035-49c5-ad18-c34e3d007800"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
