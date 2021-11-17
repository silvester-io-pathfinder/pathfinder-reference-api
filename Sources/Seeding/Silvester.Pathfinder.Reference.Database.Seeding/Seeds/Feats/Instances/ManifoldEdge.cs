using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManifoldEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("3a29a989-71e1-4842-a8a2-609ab912a582");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Manifold Edge",
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
            yield return new TextBlock { Id = Guid.Parse("03d96358-ccd4-4ae1-9e36-9a6ab9719a17"), Type = TextBlockType.Text, Text = "You’ve learned every possible edge to use against your foes. When you use (feat: Hunt Prey), you can gain a hunter’s edge benefit other than the one you selected at 1st level. If you do, you don’t gain the additional benefit from masterful hunter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("2fb5d3ae-ea57-45cf-967c-a5bea1c5b157"), ClassFeatures.Rangers.HuntersEdge.ID);
            builder.HaveSpecificClassFeature(Guid.Parse("f8bbf72b-4921-466b-bfc4-1530a5011f6e"), ClassFeatures.Rangers.MasterfulHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92097a05-1cc2-4806-b1d4-7683e1e278bc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
