using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("e4c634c4-72ed-4ce3-9f86-75a6bd8c2c67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("76e192d2-4d98-499b-8605-4ed01a5c941e"), Type = TextBlockType.Text, Text = "Multidisciplinary magical theory grants your familiar even more magic than other familiars. You can select a base of six familiar or master abilities each day, instead of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("968173a1-6744-4e2e-96c3-1eba67e7e4bd"), Feats.Instances.EnhancedFamiliar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40be5e72-da7c-4510-bf49-b850a5313725"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
