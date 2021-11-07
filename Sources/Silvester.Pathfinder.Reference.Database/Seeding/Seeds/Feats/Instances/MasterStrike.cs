using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("49afd900-8030-4df7-9694-65a4d5f96dc9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Strike hits a flat-footed creature and deals damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fe37233-5648-4e8c-8673-8f078c0fbd7b"), Type = TextBlockType.Text, Text = "The target attempts a Fortitude save against your class DC. It then becomes temporarily immune to your Master Strike for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("be2bbc35-c8c8-42fe-beea-b8c485047abd"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is enfeebled 2 until the end of your next turn.",
                Failure = "The target is paralyzed for 4 rounds.",
                CriticalFailure = "The target is paralyzed for 4 rounds, knocked unconscious for 2 hours, or killed (your choice).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1518208c-0371-4553-8d93-7331bec36498"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
