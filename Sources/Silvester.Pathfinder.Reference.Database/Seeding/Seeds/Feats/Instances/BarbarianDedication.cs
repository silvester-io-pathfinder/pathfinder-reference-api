using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarbarianDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("82f5eeee-1da8-4013-bc02-e917b629f621");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Barbarian Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the barbarian archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a09a02db-c762-4f06-a757-25c4c4e0b0f6"), Type = TextBlockType.Text, Text = "You become trained in Athletics; if you were already trained in Athletics, you instead become trained in a skill of your choice. You become trained in barbarian class DC." };
            yield return new TextBlock { Id = Guid.Parse("4af87487-4ed7-4019-9d5c-7054c59bae02"), Type = TextBlockType.Text, Text = "You can use the (feat: Rage) action." };
            yield return new TextBlock { Id = Guid.Parse("3d9bdd0b-e388-4449-9005-ba452a9b15ed"), Type = TextBlockType.Text, Text = "Choose an instinct as you would if you were a barbarian. You have that instinct for all purposes and become bound by its anathema, but you don’t gain any of the other abilities it grants." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("c57f2709-7524-4e18-a1da-f6d43b134005"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("24055ca9-24a0-416e-9cb4-4542381dda2b"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cdd50c1-0bf5-4d68-a44f-7bccf581edb4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
