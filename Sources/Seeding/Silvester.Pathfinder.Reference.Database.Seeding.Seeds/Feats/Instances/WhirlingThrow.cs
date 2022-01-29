using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlingThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("dbfcd3a1-8d62-45a6-9363-c13160854d4d");

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
            yield return new TextBlock { Id = Guid.Parse("a2c8dee8-d380-443e-b12d-3ff4afdb677d"), Type = TextBlockType.Text, Text = $"You propel your grabbed or restrained foe a great distance. You can throw the creature any distance up to 10 feet, plus 5 feet &#215; your Strength modifier. If you successfully throw the creature, it takes bludgeoning damage equal to your Strength modifier plus 1d6 per 10 feet you threw it." };
            yield return new TextBlock { Id = Guid.Parse("cb34c0ad-3221-4bd0-9f61-ce8b5ecf1499"), Type = TextBlockType.Text, Text = $"Attempt an Athletics check against the foe's Fortitude DC. You take a -2 circumstance penalty to your check if the target is one size larger than you and a -4 circumstance penalty if it's larger than that. You gain a +2 circumstance bonus to your check if the target is one size smaller than you and a +4 circumstance bonus if it's smaller than that." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a6a28701-782f-42a7-92c3-742d52b09421"),
                CriticalSuccess = "You throw the creature the desired distance and it lands prone.",
                Success = "You throw the creature the desired distance.",
                Failure = "You don't throw the creature.",
                CriticalFailure = "You don't throw the creature, and it's no longer grabbed or restrained by you.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b2bfc20-55ac-44a5-8513-56720f4648fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
