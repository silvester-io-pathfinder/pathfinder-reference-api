using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("5b166e69-3c17-44bc-84c5-a8b29fc0a32e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Master",
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
            yield return new TextBlock { Id = Guid.Parse("c01d1784-0bfa-43ff-a86f-aec9a1b81a84"), Type = TextBlockType.Text, Text = $"You adapt to your surroundings in any natural terrain. You can spend 1 hour practicing in your current terrain in order to make it your favored terrain, replacing your current favored terrain temporarily. If you spend a full day out of the new favored terrain, your favored terrain reverts back to your original choice when you took the {ToMarkdownLink<Models.Entities.Feat>("Favored Terrain", Feats.Instances.FavoredTerrain.ID)} feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9d159cd2-b9ec-4a40-be8e-95b580447da7"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0797da68-de1a-43b6-b26a-b0bb1afe4f8d"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2283a17a-d097-46cb-a9f6-d51fde6e73e3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
