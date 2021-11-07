using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteelSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("b05359ce-0dff-46b1-8c87-caf780a4ec4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steel Skin",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b8baa02-06ef-4d88-80d8-76540cf38c8f"), Type = TextBlockType.Text, Text = "You wear your armor like a second skin. You can rest normally while wearing medium armor. If you are a master in heavy armor, you can also rest normally while wearing heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("da6df583-4813-4628-a65e-508f115b7130"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificFeat(Guid.Parse("50acf795-eede-4954-b17c-8297f174cabf"), Feats.Instances.SentinelDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05a7fad8-aca8-48e0-a044-b913bb32358c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
