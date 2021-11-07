using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GritAndTenacity : Template
    {
        public static readonly Guid ID = Guid.Parse("0a8d33b3-bff0-46cb-871d-a28a9d389159");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grit and Tenacity",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a Fortitude or Will save.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26c23ddd-feb2-4389-ba89-efcb54a38244"), Type = TextBlockType.Text, Text = "You call upon deep reserves of toughness and mental fortitude to power through an otherwise debilitating effect. Reroll the triggering save with a +2 circumstance bonus; you must use the second result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("940a0255-1d8f-4fbb-ab7d-8358f0f67a48"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
