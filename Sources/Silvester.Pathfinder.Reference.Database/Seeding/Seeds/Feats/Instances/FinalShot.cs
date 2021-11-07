using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("552f4057-dccf-4dde-b527-4752eff0f9c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Final Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4b33b72-459e-4976-8afa-6fcc2fb9bb56"), Type = TextBlockType.Text, Text = "You jam a triple charge of black powder into your weapon to unleash a devastating but risky and inaccurate attack. (action: Interact) to reload, expending three doses of black powder in addition to your normal black powder or ammunition, then (action: Strike) with your firearm against a creature within the weapon’s first range increment. If you roll a success, the attack is instead a critical success, but if you roll a failure, the weapon (trait: misfires|misfire). Regardless of your roll, after the attack you’re flat-footed until the start of your next turn and stunned 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54794147-3019-4edf-8b16-0dfe8282e992"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
