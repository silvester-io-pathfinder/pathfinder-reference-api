using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrikingRetribution : Template
    {
        public static readonly Guid ID = Guid.Parse("04d141be-e058-4f59-aba8-2c0213c20da7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Striking Retribution",
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
            yield return new TextBlock { Id = Guid.Parse("77a2bb67-669c-4d25-8265-7a1dfc90c7df"), Type = TextBlockType.Text, Text = "You have an appropriately intense hatred for alghollthus. You gain a +2 circumstance bonus to damage with weapons and unarmed attacks against creatures from the alghollthu family and those that serve alghollthus (the GM determines which creatures serve an alghollthu). In addition, if an alghollthu successfully affects you or one of your allies within 60 feet with an enchantment, your circumstance bonus to damage against that alghollthu increases to +4 for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86bc4f70-ca1d-4908-932b-d4100e9fa592"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
