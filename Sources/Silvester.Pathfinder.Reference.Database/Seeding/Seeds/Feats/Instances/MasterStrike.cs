using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("d5656fc3-db4e-4962-8582-9d632bc79234");

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
            yield return new TextBlock { Id = Guid.Parse("e33d147f-b663-4da4-9600-65703801959c"), Type = TextBlockType.Text, Text = "The target attempts a Fortitude save against your class DC. It then becomes temporarily immune to your Master Strike for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("bee6efdf-b896-4198-a783-ac2458390959"),
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
                Id = Guid.Parse("041cbf4e-59f7-4a4b-92c6-aa8dec7911e5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
