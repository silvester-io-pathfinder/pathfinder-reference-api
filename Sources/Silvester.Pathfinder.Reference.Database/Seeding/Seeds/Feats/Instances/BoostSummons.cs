using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoostSummons : Template
    {
        public static readonly Guid ID = Guid.Parse("950a2164-2436-4484-8557-410614c1458d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boost Summons",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8446ebeb-a27a-481c-bd50-33a8e3e95162"), Type = TextBlockType.Text, Text = "Augmenting your eidolon extends to creatures you summon. When you cast (spell: boost eidolon), in addition to your eidolon, it also targets your summoned creatures within 60 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46179ce2-efe7-4868-8455-8c88bb055bd6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
