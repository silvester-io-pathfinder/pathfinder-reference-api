using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Darkseer : Template
    {
        public static readonly Guid ID = Guid.Parse("b2a6b88f-4cfd-4a58-9511-d24cd2ffc3d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Darkseer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e7616b9-27f3-4355-84d3-afd2e2188e5d"), Type = TextBlockType.Text, Text = "Zon-Kuthon smiles upon you – even if you curse his name – granting you pitch-black eyes that allow you to see in shadows and darkness. You gain darkvision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("45a17a12-adf6-406e-8e64-f26f3a30d664"), Feats.Instances.Gloomseer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e692fe6-b258-426f-87ea-61468aa55a50"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
