using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DebilitatingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("6506831d-f421-4dff-9ab8-3becb7127edc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Bomb",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb that is at least 2 levels lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3866fd12-89c3-4eb5-ae33-3e931001b42d"), Type = TextBlockType.Text, Text = "Your bombs impose additional effects on your enemies. You mix a substance into the bomb that causes one of the following: dazzled, deafened, flat-footed, or a -5-foot status penalty to Speeds. If the attack with that bomb hits, the target must succeed at a Fortitude saving throw or suffer that effect until the start of your next turn. Use your class DC for this saving throw (even if someone else throws the bomb)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d19a03c8-9f45-4ab2-9b05-ca1632a5c98c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
