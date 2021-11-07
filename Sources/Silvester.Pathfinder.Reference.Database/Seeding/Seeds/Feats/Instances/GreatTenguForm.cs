using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreatTenguForm : Template
    {
        public static readonly Guid ID = Guid.Parse("fa88f199-0723-4834-aaba-00a2ba1d357e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Tengu Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1056f2e5-51a2-45d4-bb3b-69e63e038856"), Type = TextBlockType.Text, Text = "You take on the imposing form of a large, winged oni. Once per day, as part of using (feat: Long-Nosed Form), you also gain the benefits of 4th-level (spell: enlarge) and (spell: fly). This lasts for 5 minutes or until you shift out of your (feat: Long-Nosed Form), whichever happens first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c73fe5e-affd-4bf4-b2a3-486a723f5542"), Feats.Instances.LongNosedForm.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c386ea57-e862-4bca-92c7-a533907a5901"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
