using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwordmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("73de7391-28f1-42e2-827e-d70b7f667b65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swordmaster Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Swordmaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c44f728-5abd-4160-8781-b6d74474e906"), Type = TextBlockType.Text, Text = "Your Swords training taught you to never lose hold of your weapon. You gain a +2 circumstance bonus to your Reflex DC when foes attempt to (action: Disarm) you. If you have the (feat: Deft Cooperation) feat and critically succeed on a check to (action: Aid) an ally’s attack roll or skill check, you gain a +2 circumstance bonus from (feat: Deft Cooperation) (instead of a +1 bonus) the first time you attempt an attack roll or attempt a skill check where the bonus would apply." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("e2ac60a8-fe47-4e88-b616-3c181d2b4097"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("1f7760a6-dace-4d7a-8b00-957e7f6b58aa"), requiredStatValue: 14, Stats.Instances.Strength.ID);
                or.HaveSpecificStat(Guid.Parse("39dfb73f-5bf9-4dd4-9ef7-47eabf51a72a"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
                or.HaveSpecificStat(Guid.Parse("e37430d7-894f-43e0-8ef4-a29ed79ca083"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
            });
            builder.Manual(Guid.Parse("e989ab2c-e616-4b48-8512-a519d764b9f1"), "Member of the Pathfinder Society affiliated with the School of Swords.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("178957fb-12dd-46c5-9cbe-c9638ec7edda"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
