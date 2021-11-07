using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrayerAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("d2bc957a-f9de-4a9b-b377-f3fad78c24b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prayer Attack",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30f7ddbb-b8d9-4f59-ba09-dae2221d7114"), Type = TextBlockType.Text, Text = "You’ve mastered the signature assassination style of the Red Mantis. Attempt to (action: Feint) an enemy within 30 feet. If your (action: Feint) is successful, when you use Prayer Attack on subsequent turns you automatically make the target flat-footed against your melee attacks for that turn without rolling a check to (action: Feint), so as long as you remain visible to the target and the target remains within 30 feet of you. If you use your Prayer Attack against a different target, you must attempt to (action: Feint) the target normally." };
            yield return new TextBlock { Id = Guid.Parse("462c8cea-a3ee-4576-9023-106ff3965a09"), Type = TextBlockType.Text, Text = "When you use Prayer Attack, your next successful (action: Strike) with a (item: sawtooth saber) that turn deals 2d6 persistent bleed damage to the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f52182b-d611-4ccd-95d5-73a2feebbf3a"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a31a5c1e-8c44-44a5-87ef-9e64fc07390f"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
