using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VitalityManipulatingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("6540620f-baf4-46c8-b48b-b1638f7cd50c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vitality-Manipulating Stance",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93ed5f27-4a6e-4359-b06d-52b71f06ebda"), Type = TextBlockType.Text, Text = "You have learned to attack meridians and pressure points like your rival Shino Hakusa. You gain a vitality blast ranged unarmed (action: Strike) that deals 1d4 negative damage, has a range of 30 feet, and has the (trait: unarmed) and (trait: versatile) (trait: positive) traits." };
            yield return new TextBlock { Id = Guid.Parse("bb8903b8-18ca-46f9-b2c8-1e275e18bc73"), Type = TextBlockType.Text, Text = "Additionally, when you use (feat: Stunning Fist), instead of saving against being stunned, you can choose to have the target make a Fortitude save against your class DC with the following results. You must choose to do this before the target rolls its save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d10ce6e7-5297-4709-956b-372f4d1afb83"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target&#39;s muscles become temporarily weaker. For 1 round, the target is enfeebled 2, and any time it attempts to take an action with the (trait: manipulate) trait, the action is disrupted unless it succeeds at a flat check with a DC equal to 5 + its enfeebled value.",
                Failure = "As success, but the duration is 1 minute.",
                CriticalFailure = "As success, but the duration is 1 minute, the flat check is DC 11, and the target takes –10-foot status penalty to all Speeds for the duration.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4418b947-7e8e-49b5-96ba-5a53853680b0"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
