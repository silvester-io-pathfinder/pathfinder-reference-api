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
    public class ImperviousVehicle : Template
    {
        public static readonly Guid ID = Guid.Parse("67af29c1-b976-48ed-8ff9-1585c0c0e58c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impervious Vehicle",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b1bdd31-6b21-4cdb-be47-cbee558d8ac6"), Type = TextBlockType.Text, Text = $"From armor plating and flexible components, to reinforced materials and backup redundant functionality, you have built safeguards to protect your vehicle from the rigors of combat. Your signature vehicle gains a +1 circumstance bonus to AC and Fortitude saves, and increases its Hit Points by an amount equal to twice your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a6fea9d-88d2-47c2-af9d-73d907f8e1b2"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e66b4962-ffad-4883-a181-2b6002933249"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
