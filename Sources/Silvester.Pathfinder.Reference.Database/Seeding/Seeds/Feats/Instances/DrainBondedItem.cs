using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrainBondedItem : Template
    {
        public static readonly Guid ID = Guid.Parse("19136c15-0e06-40f3-802e-8ea18bd0e549");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drain Bonded Item",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d282b28d-ac55-49d1-a5b4-4fa1fba565b2"), Type = TextBlockType.Text, Text = "You expend the power stored in your bonded item. During your turn, you gain the ability to cast one spell you prepared today and already cast, without spending a spell slot. You must still (activity: Cast the Spell | Cast a Spell) and meet the spell’s other requirements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ab207b7-4a61-409c-9e8e-6c2b8122e071"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
