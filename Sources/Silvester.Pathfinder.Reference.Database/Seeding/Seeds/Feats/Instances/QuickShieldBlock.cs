using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickShieldBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("1c583ade-083e-48d9-b339-1656cadd5ce3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Shield Block",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1884c56-c28e-42d0-bef0-cb6ac2575247"), Type = TextBlockType.Text, Text = "You can bring your shield into place with hardly a thought. At the start of each of your turns, you gain an additional reaction that you can use only to (feat: Shield Block)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9cba0ea4-5260-443b-b310-526b91df6003"), Feats.Instances.VikingDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("4b7d0640-1049-4672-b679-691c405362f8"), Feats.Instances.ShieldBlock.ID);
            builder.HaveSpecificFeat(Guid.Parse("526f5db5-75f2-4e38-aacd-2928076489d5"), Feats.Instances.ReactiveShield.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11825d1-988c-4deb-831f-ffeff560a56f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
