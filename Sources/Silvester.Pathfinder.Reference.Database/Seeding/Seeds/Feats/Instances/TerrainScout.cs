using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainScout : Template
    {
        public static readonly Guid ID = Guid.Parse("a5f13de5-b075-4654-b5c3-2dfe449f9f69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Scout",
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
            yield return new TextBlock { Id = Guid.Parse("6fe088a3-aa8e-41de-9abf-ff4b7b50ba96"), Type = TextBlockType.Text, Text = "You gain the (feat: Terrain Stalker) skill feat twice, choosing a different terrain each time. If you (action: Avoid Notice) while exploring and any allies use (action: Follow the Expert) to follow you as you do so, you can choose one of those allies to gain the benefit of any one (feat: Terrain Stalker) feat you have." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4a91b44c-2261-4be6-ba0f-cd55e82d67bb"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55106de6-9529-4dbb-97f2-36f415567623"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
