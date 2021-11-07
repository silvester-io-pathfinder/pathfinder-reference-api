using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleTechnique : Template
    {
        public static readonly Guid ID = Guid.Parse("aa0bed5b-ea64-49cf-959a-eb07f557dbfe");

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
            yield return new TextBlock { Id = Guid.Parse("b50fc19f-a62d-4fd6-943d-5f504d452f20"), Type = TextBlockType.Text, Text = "You execute a maneuver that defies possibility. If the triggering effect was an enemy’s attack hitting you, the enemy rerolls the attack roll and uses the lower result. If the triggering effect was you failing a saving throw, you reroll the saving throw and use the higher result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee0fe15f-d575-4744-ae48-ba4851d2b89e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
