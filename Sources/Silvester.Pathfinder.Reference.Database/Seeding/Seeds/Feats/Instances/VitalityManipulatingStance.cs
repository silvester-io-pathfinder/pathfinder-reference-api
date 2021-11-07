using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VitalityManipulatingStance : Template
    {
        public static readonly Guid ID = Guid.Parse("081d6527-2168-42f7-a475-ad63c5bdf6bc");

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
            yield return new TextBlock { Id = Guid.Parse("4b0d09c9-0130-428e-bbaa-922ccb92ecb1"), Type = TextBlockType.Text, Text = "You have learned to attack meridians and pressure points like your rival Shino Hakusa. You gain a vitality blast ranged unarmed (action: Strike) that deals 1d4 negative damage, has a range of 30 feet, and has the (trait: unarmed) and (trait: versatile) (trait: positive) traits." };
            yield return new TextBlock { Id = Guid.Parse("1e11b104-ecb8-435d-80e4-067f4dbe3120"), Type = TextBlockType.Text, Text = "Additionally, when you use (feat: Stunning Fist), instead of saving against being stunned, you can choose to have the target make a Fortitude save against your class DC with the following results. You must choose to do this before the target rolls its save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c2326d50-7745-4705-93cc-2977712bb46c"),
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
                Id = Guid.Parse("4712579b-4b0b-49f0-96af-ab9b9d1ed0d5"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
