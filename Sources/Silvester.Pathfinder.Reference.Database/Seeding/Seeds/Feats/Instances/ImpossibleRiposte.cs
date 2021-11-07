using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("73438fcd-f1aa-4fdb-822b-32db51ef1c88");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Riposte",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c40efd1d-4003-4be0-ada5-0d1ea8c890e3"), Type = TextBlockType.Text, Text = "Your ripostes can deflect attacks back at their source. You can use (feat: Opportune Riposte) with a trigger of “A foe outside of your reach critically fails an attack roll against you” in addition to its usual trigger. When you use (feat: Opportune Riposte) with this new trigger against a ranged attack, your (action: Strike) deflects some of the triggering effect back toward its source. Compare the result of your attack roll to the AC of the triggering foe. On a hit, you deal the normal amount of damage for your (action: Strike), but the damage type changes to that of the triggering attack. For instance, if you used (feat: Opportune Riposte) to deflect a (spell: ray of frost), your (action: Strike) would deal cold damage instead of its normal damage type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d8d0eae-78f7-4e0e-b521-30649be96b06"), Feats.Instances.OpportuneRiposte.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("916ff8ba-a4d2-4411-b009-8783c754af32"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
