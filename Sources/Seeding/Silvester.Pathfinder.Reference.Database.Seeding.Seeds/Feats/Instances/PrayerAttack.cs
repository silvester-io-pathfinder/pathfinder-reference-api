using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrayerAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("6847c503-08cf-40ac-8255-898cefe58ee6");

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
            yield return new TextBlock { Id = Guid.Parse("cfbb4605-6f34-42b6-a43d-696801018512"), Type = TextBlockType.Text, Text = "You've mastered the signature assassination style of the Red Mantis. Attempt to (action: Feint) an enemy within 30 feet. If your (action: Feint) is successful, when you use Prayer Attack on subsequent turns you automatically make the target flat-footed against your melee attacks for that turn without rolling a check to (action: Feint), so as long as you remain visible to the target and the target remains within 30 feet of you. If you use your Prayer Attack against a different target, you must attempt to (action: Feint) the target normally." };
            yield return new TextBlock { Id = Guid.Parse("1e934c3d-9eb3-421c-b860-34fca7c876d8"), Type = TextBlockType.Text, Text = "When you use Prayer Attack, your next successful (action: Strike) with a (item: sawtooth saber) that turn deals 2d6 persistent bleed damage to the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6a715280-9c97-4991-83be-7466b5e1dc36"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f473fb20-3cef-416e-a583-afd02a0c6e94"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
