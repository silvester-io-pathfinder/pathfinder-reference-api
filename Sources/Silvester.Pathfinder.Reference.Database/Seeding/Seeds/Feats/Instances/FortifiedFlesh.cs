using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FortifiedFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("26e8c4f7-8715-4ab4-af45-193bfb5ed637");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fortified Flesh",
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
            yield return new TextBlock { Id = Guid.Parse("7629f6f9-d098-4754-8373-0010a30bdbfe"), Type = TextBlockType.Text, Text = "Your flesh takes on the hardness of stone. You gain resistance to physical damage (except adamantine) equal to your number of class feats from the Living Monolith archetype." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("25691aab-04ca-438b-b3bb-a942b9397618"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a36af72-6cfd-4b01-abe7-ca3fa0d5e64d"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
