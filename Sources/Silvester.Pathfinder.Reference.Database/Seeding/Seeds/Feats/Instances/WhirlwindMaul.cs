using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindMaul : Template
    {
        public static readonly Guid ID = Guid.Parse("8404c448-f8bd-40a6-bafb-a8eb1f24d6d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Maul",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3678fc73-f503-447d-a3a4-daa1166fdd1b"), Type = TextBlockType.Text, Text = "Your eidolon lashes out in all directions. It makes a melee unarmed (action: Strike) against up to four enemies within reach. It can choose different unarmed attacks for each enemy. Each attack counts toward your multiple attack penalty, but you don’t increase your penalty until the eidolon has made all its attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d5ebf24-b729-4a2e-a923-f243d118f34a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
