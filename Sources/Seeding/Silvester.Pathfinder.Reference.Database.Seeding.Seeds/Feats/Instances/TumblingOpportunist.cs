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
    public class TumblingOpportunist : Template
    {
        public static readonly Guid ID = Guid.Parse("7e83229c-4c1c-4105-beb9-09064342b93a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tumbling Opportunist",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0549c5c9-4e08-45af-a100-747147cf0ba2"), Type = TextBlockType.Text, Text = $"You use a burst of stamina to perform a breathtaking feat of Acrobatics as you speed through a foe's space, leaving your foe lying flat on their back. You attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} the enemy whose space you moved through. You can use Acrobatics instead of Athletics for this check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("305a0e6d-c5f7-4e05-8390-2a00b55bdce4"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a0047142-15fd-472b-97f8-04d6e3fac0aa"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("28d4556f-de5c-49b0-964e-6568a6abd29a"), Traits.Instances.Attack.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2636aee-bf94-4c3b-a4c1-9f53f04b5491"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
