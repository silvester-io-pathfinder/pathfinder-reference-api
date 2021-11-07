using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ViciousVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("598796c7-e619-43c5-8581-fad01aff7eae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vicious Vengeance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6f8d0c6-9382-4d71-9a82-be5627d055a6"), Type = TextBlockType.Text, Text = "While your vengeance is painful for both you and your foe, none can doubt that your enemies suffer more. You gain a circumstance bonus to the damage you deal from (feat: Destructive Vengeance) equal to the number of damage dice from the reaction. This only applies to the damage the enemy takes, not the damage to yourself or the extra damage you gain after using the reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("d0a223da-979b-4595-bd94-a508242b6563"), Causes.Instances.Antipaladin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8adf4b45-29d9-423a-b9d8-e5578f45acf8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
