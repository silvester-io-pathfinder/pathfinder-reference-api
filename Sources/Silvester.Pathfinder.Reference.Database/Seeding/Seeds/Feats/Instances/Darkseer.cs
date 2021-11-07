using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Darkseer : Template
    {
        public static readonly Guid ID = Guid.Parse("63ec2f72-d451-4714-a6a2-9d8822e9168d");

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
            yield return new TextBlock { Id = Guid.Parse("b43921cd-8fca-4e60-9a2f-8a2b94bc1e3d"), Type = TextBlockType.Text, Text = "Zon-Kuthon smiles upon you – even if you curse his name – granting you pitch-black eyes that allow you to see in shadows and darkness. You gain darkvision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9f68ac2e-55d4-47a2-b468-55ae84a6d85c"), Feats.Instances.Gloomseer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbb4dadf-2ef1-4598-a9d0-13f1495dfb54"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
