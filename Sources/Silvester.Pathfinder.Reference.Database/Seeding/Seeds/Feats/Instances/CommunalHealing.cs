using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommunalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("ac290946-7281-4311-a38d-da74b675a5e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Communal Healing",
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
            yield return new TextBlock { Id = Guid.Parse("e647c647-8767-429d-af96-2b6bf34b10f8"), Type = TextBlockType.Text, Text = "You’re a conduit for positive energy, and as you channel it through you, it heals some of your minor injuries. When you cast the (spell: heal) spell to heal a single creature other than yourself, you regain Hit Points equal to the spell level of the heal spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e917d35a-5e3c-4ebd-8067-ffbaa36db07c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
