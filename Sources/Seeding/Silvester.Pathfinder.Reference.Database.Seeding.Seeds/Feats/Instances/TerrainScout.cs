using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainScout : Template
    {
        public static readonly Guid ID = Guid.Parse("e0856150-1e4c-4fcc-8ea6-f3f71a8e796a");

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
            yield return new TextBlock { Id = Guid.Parse("0f0d0f63-574b-4048-8a7b-59eacf2412a8"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Feat>("Terrain Stalker", Feats.Instances.TerrainStalker.ID)} skill feat twice, choosing a different terrain each time. If you {ToMarkdownLink<Models.Entities.Activity>("Avoid Notice", Activities.Instances.AvoidNotice.ID)} while exploring and any allies use {ToMarkdownLink<Models.Entities.Activity>("Follow the Expert", Activities.Instances.FollowTheExpert.ID)} to follow you as you do so, you can choose one of those allies to gain the benefit of any one {ToMarkdownLink<Models.Entities.Feat>("Terrain Stalker", Feats.Instances.TerrainStalker.ID)} feat you have." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("156d150f-3996-4de4-94b9-61980b853455"), Feats.Instances.ScoutDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b24ec472-bccc-41e1-ae7c-0cd3affae223"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
