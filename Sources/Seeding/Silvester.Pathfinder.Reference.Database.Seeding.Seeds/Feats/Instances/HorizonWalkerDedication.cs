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
    public class HorizonWalkerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0826fa5d-fae6-4d4f-b21f-4c141465219a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Horizon Walker Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the horizon walker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0ac7065-4084-471b-bd79-86727a475eb8"), Type = TextBlockType.Text, Text = $"You've mastered travel within a specific type of terrain. You gain the {ToMarkdownLink<Models.Entities.Feat>("Favored Terrain", Feats.Instances.FavoredTerrain.ID)} feat. When in your favored terrain, you gain a +10-foot circumstance bonus to your travel Speed. When other creatures {ToMarkdownLink<Models.Entities.Activity>("Follow the Expert", Activities.Instances.FollowTheExpert.ID)} with you as a guide in your favored terrain, they gain both the ability to ignore non-magical difficult terrain for the purpose of their travel Speed and the bonus to travel Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0b6d7e22-1e2c-4ae9-b0c4-e012f829a9ca"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab9c36bd-fafb-4714-8dfd-34e022c30ed4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
