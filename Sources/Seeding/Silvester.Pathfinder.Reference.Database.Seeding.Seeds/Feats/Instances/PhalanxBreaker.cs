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
    public class PhalanxBreaker : Template
    {
        public static readonly Guid ID = Guid.Parse("680ae0fa-c1eb-4d46-b889-3dcb539433e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phalanx Breaker",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a72f2e8-0972-46c9-b211-1ffc5573defb"), Type = TextBlockType.Text, Text = $"You know that to take out an enemy formation, you must punch a hole through its center. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon against a target within the weapon's first range increment. The target is pushed directly back 10 feet (20 feet on a critical hit), and if this pushes the target into an obstacle, the target takes bludgeoning damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("f55f095b-b969-4738-a9fc-40c76d2c3940"), GunslingersWays.Instances.WayOfTheVanguard.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7da4f311-71cb-4bed-9144-0223008fc295"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
