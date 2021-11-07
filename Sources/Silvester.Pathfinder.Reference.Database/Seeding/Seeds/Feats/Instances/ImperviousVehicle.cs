using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImperviousVehicle : Template
    {
        public static readonly Guid ID = Guid.Parse("6801a65f-bffd-4c70-be28-6eabb0854485");

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
            yield return new TextBlock { Id = Guid.Parse("8aa416af-8f16-4ffd-8bef-c285ef333f0e"), Type = TextBlockType.Text, Text = "From armor plating and flexible components, to reinforced materials and backup redundant functionality, you have built safeguards to protect your vehicle from the rigors of combat. Your signature vehicle gains a +1 circumstance bonus to AC and Fortitude saves, and increases its Hit Points by an amount equal to twice your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3799faf6-7879-4934-9d8f-dbd185d0926d"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d231ee47-d7d0-454f-a529-193cf665f1c8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
