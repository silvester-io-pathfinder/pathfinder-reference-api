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
    public class ViciousVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("ad2f2c89-4c01-472c-b386-29f326dd4e34");

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
            yield return new TextBlock { Id = Guid.Parse("b17ab7bd-006e-4c63-90fd-b6b71faab936"), Type = TextBlockType.Text, Text = $"While your vengeance is painful for both you and your foe, none can doubt that your enemies suffer more. You gain a circumstance bonus to the damage you deal from {ToMarkdownLink<Models.Entities.Feat>("Destructive Vengeance", Feats.Instances.DestructiveVengeance.ID)} equal to the number of damage dice from the reaction. This only applies to the damage the enemy takes, not the damage to yourself or the extra damage you gain after using the reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("feb0b037-4715-48f5-b620-0180fc6d5470"), Causes.Instances.Antipaladin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d0b5871-6fec-4f2f-ae73-df84b4d23cb4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
