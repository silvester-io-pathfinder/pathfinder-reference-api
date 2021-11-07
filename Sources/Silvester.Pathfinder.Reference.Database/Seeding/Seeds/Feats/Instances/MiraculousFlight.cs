using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MiraculousFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("0e8596ac-e402-4417-96e1-8fe74bfff825");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miraculous Flight",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e5a5813-9c3e-48b1-abe1-3b7a2c0ce7f6"), Type = TextBlockType.Text, Text = "With superior engineering and magical application, you have freed your signature vehicle from the bonds of gravity, allowing it to soar through the sky like a dragon. The vehicle gains magical propulsion and a fly Speed equal to its fastest current Speed. If your signature vehicle already had a fly Speed, reduce the distance the vehicle needs to make a 90-degree turn to half the usual length (typically half the length of the vehicle)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("03759d3f-a00a-499d-acbe-ba35f4fbd8fe"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("717cb7ff-b472-4a38-8047-9f8d716f33db"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
