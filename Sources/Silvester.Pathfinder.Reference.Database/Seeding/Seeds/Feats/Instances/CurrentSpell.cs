using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CurrentSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("59d8bd86-88fc-4591-898d-9b63db188adc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Current Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d31aaa2-1aa5-4d05-b1c6-c6186a31f886"), Type = TextBlockType.Text, Text = "As you use your magic to manipulate air or water, you divert some of its currents to form a barrier around you. If your next action is to (activity: Cast a Spell) with the (trait: air) or (trait: water) trait, until the start of your next turn, you gain a +1 circumstance bonus to AC or a +2 circumstance bonus against ranged attacks. This effect has the (trait: air) or (trait: water) trait, or both, depending on the traits of the spell you cast. You also gain a +1 circumstance bonus to all saves against effects with the (trait: air) trait, (trait: water) trait, or both until the start of your next turn, depending on the spell’s traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fdecf0a-c3f9-48f4-94f3-db4473a62db0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
