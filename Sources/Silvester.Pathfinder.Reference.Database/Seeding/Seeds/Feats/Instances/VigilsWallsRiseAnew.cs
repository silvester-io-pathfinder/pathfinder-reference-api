using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VigilsWallsRiseAnew : Template
    {
        public static readonly Guid ID = Guid.Parse("32d33736-e5e7-454b-8122-e38a33d2d124");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vigil's Walls Rise Anew!",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("154c4f7d-078b-4b71-b2ac-e88e81fbcce9"), Type = TextBlockType.Text, Text = "As part of daily preparation, you can drill with a number of allies up to your Charisma modifier. These allies must be present and listening during this time, but this does not otherwise impede their own preparation. When you use this feat’s benefit, you and all drilled companions within 30 feet who are wielding shields (action: Raise a Shield). Allies who (action: Raise their Shields | Raise a Shield) keep them raised until the start of their next turn, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cdd7b901-d456-4b47-8c62-5a3fb1e8c9a7"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("ec951c35-ae42-4f92-b77a-4bc35c2f6143"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f8a4ebc-572b-4c49-8373-6974c34b7745"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
