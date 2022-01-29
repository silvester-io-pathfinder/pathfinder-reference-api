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
    public class UnendingEmptiness : Template
    {
        public static readonly Guid ID = Guid.Parse("44d27391-fde4-4433-a376-00ad218aa0c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unending Emptiness",
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
            yield return new TextBlock { Id = Guid.Parse("4b1e5521-d66c-4b38-b821-c33c391333f0"), Type = TextBlockType.Text, Text = $"You pool the power of shadow within your eyes, gaining the ability to gather darkness into a turbulent orb of crushing emptiness within your line of sight. You gain the {ToMarkdownLink<Models.Entities.Spell>("darklight", Spells.Instances.Darklight.ID)} domain spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("6c1ebc0f-9f68-43f9-89ce-ce97fa0416ae"));
            builder.HaveSpecificFeat(Guid.Parse("868f222f-5c64-4a96-bf53-f95d11569828"), Feats.Instances.ShadowcasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("135df6f0-253f-48d3-8702-c73b6bf9f66a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
