using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleTechnique : Template
    {
        public static readonly Guid ID = Guid.Parse("6f8f3812-56cd-4a77-ae6d-e9278cd7c5fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Technique",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy's attack hits you or you fail a saving throw against an enemy's ability.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0658d3fc-3660-4736-8df4-7ebb4d16b6b6"), Type = TextBlockType.Text, Text = $"You execute a maneuver that defies possibility. If the triggering effect was an enemy's attack hitting you, the enemy rerolls the attack roll and uses the lower result. If the triggering effect was you failing a saving throw, you reroll the saving throw and use the higher result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58227843-a2e1-4c8a-9ca1-a49d6606209f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
