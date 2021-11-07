using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmasterBond : Template
    {
        public static readonly Guid ID = Guid.Parse("46eb02b1-d71b-49f9-88d5-ec0c0552474e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastmaster Bond",
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
            yield return new TextBlock { Id = Guid.Parse("5d601d26-a9cd-46d8-a34c-51e34400e162"), Type = TextBlockType.Text, Text = "You can communicate telepathically with your animal companions within 100 feet. If you’re legendary in Nature, you can communicate telepathically with your animal companions anywhere on the planet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("97bbadc7-817f-4376-803a-931c523d067f"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f939c02d-5d66-447c-a93f-23c62e01dea1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
