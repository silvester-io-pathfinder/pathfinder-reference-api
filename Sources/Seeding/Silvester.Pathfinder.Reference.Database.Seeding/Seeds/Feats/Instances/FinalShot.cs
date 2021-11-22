using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("50fe0065-053b-4b3c-a41f-62cb60db3d77");

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
            yield return new TextBlock { Id = Guid.Parse("5daefb4b-3580-4804-9c0a-1bdd241bf04a"), Type = TextBlockType.Text, Text = "You jam a triple charge of black powder into your weapon to unleash a devastating but risky and inaccurate attack. (action: Interact) to reload, expending three doses of black powder in addition to your normal black powder or ammunition, then (action: Strike) with your firearm against a creature within the weapon's first range increment. If you roll a success, the attack is instead a critical success, but if you roll a failure, the weapon (trait: misfires|misfire). Regardless of your roll, after the attack you're flat-footed until the start of your next turn and stunned 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("110e7770-4dba-43a3-8d18-3aa62c86e520"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
