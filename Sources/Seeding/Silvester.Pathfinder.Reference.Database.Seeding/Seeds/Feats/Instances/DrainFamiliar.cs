using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrainFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("8ac609bc-18a4-46f3-995e-ea12707e3c55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drain Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("7aaf7ea7-bc97-4795-bae4-7d6942d57272"), Type = TextBlockType.Text, Text = "You expend the power stored in your familiar. During your turn, you gain the ability to cast one spell you prepared today and already cast, without spending a spell slot. You must still (activity: Cast the Spell | Cast a Spell) and meet the spell’s other requirements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ef399a1-71f5-4008-b9af-b811b00f302f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
