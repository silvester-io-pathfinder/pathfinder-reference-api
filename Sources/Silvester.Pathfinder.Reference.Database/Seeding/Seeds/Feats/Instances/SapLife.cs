using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SapLife : Template
    {
        public static readonly Guid ID = Guid.Parse("fc57cf52-bc83-4865-ac37-66a6a8342fd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sap Life",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7796329-5878-483d-be0e-54f8dcd8a824"), Type = TextBlockType.Text, Text = "You draw the life force out of your enemies to heal your own wounds. When you cast a (spell: harm) spell and damage at least one living creature, you regain Hit Points equal to the spell level of your harm spell. If you aren’t a living creature, you gain no benefit from this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e630705-9711-4eee-b0c9-bcc56fd59cc2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
