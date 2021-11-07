using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvincibleMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("690cc874-01e1-449f-961f-bf84f2e784a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invincible Mutagen",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d24733c-6ef8-4259-ab9e-5eaca2ff36a0"), Type = TextBlockType.Text, Text = "The fortifying additives you brew into your mutagens make your juggernaut form impervious. Whenever you’re affected by a juggernaut mutagen, you gain resistance to all physical damage equal to your Intelligence modifier (minimum 0)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ca13085-5013-45ba-9d9b-e67774e6a37b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
