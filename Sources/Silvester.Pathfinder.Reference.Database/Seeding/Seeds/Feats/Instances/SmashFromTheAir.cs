using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmashFromTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("35a303d1-2368-4ff9-9d3d-e28adf23d1de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smash from the Air",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a49593d3-b8e6-4fd8-ab4c-24c9b526b3ab"), Type = TextBlockType.Text, Text = "Your expertise enables you to knock away spells. You can use (feat: Cut from the Air) against ranged spell attack rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("46af8f27-5b62-4e42-ab88-884f59a44571"), Feats.Instances.CutFromTheAir.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb4fe306-67c5-4ab9-bb1e-3725dd5b492c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
