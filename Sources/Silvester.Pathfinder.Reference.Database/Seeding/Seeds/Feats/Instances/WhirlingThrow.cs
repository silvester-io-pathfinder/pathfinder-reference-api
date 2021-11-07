using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlingThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("c6deaaf3-41a3-4bf4-b505-a62c549fbd05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirling Throw",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af9284b4-269b-4959-9aea-85dd7f1bf33c"), Type = TextBlockType.Text, Text = "You propel your grabbed or restrained foe a great distance. You can throw the creature any distance up to 10 feet, plus 5 feet &#215; your Strength modifier. If you successfully throw the creature, it takes bludgeoning damage equal to your Strength modifier plus 1d6 per 10 feet you threw it." };
            yield return new TextBlock { Id = Guid.Parse("23fb6977-c69d-40a4-940e-fdfb833143b2"), Type = TextBlockType.Text, Text = "Attempt an Athletics check against the foe’s Fortitude DC. You take a -2 circumstance penalty to your check if the target is one size larger than you and a -4 circumstance penalty if it’s larger than that. You gain a +2 circumstance bonus to your check if the target is one size smaller than you and a +4 circumstance bonus if it’s smaller than that." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("73450280-3e90-43a7-82e8-2b36c2fc876c"),
                CriticalSuccess = "You throw the creature the desired distance and it lands prone.",
                Success = "You throw the creature the desired distance.",
                Failure = "You don’t throw the creature.",
                CriticalFailure = "You don’t throw the creature, and it’s no longer grabbed or restrained by you.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f5f270f-ada8-4a38-b1b6-afbe709a6ca5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
