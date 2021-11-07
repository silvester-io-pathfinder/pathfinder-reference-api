using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonsBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("61dba8f8-0bc8-427a-875d-c4aa9c50ef00");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Breath",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b7da03d-19bd-483c-8ac9-61867b71ef3c"), Type = TextBlockType.Text, Text = "You can put more effort into your (feat: Kobold Breath) to channel greater draconic power, though it takes more out of you. When you use (feat: Kobold Breath), you can increase the damage dice to d8s and increase the area to 60 feet for a line breath weapon or 30 feet for a cone. If you do, you can&#39;t use (feat: Kobold Breath) again for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f77a6e88-b3f4-495e-b62d-0cf1a66e662a"), Feats.Instances.KoboldBreath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7eaa8cee-a212-4edb-893c-d4dcc17d9a45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
