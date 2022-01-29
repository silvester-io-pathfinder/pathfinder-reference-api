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
    public class DanceUnderfoot : Template
    {
        public static readonly Guid ID = Guid.Parse("2d9af21d-fc9a-44c2-8cac-f28da678c512");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dance Underfoot",
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
            yield return new TextBlock { Id = Guid.Parse("2d705015-a469-469f-83b2-9df8795955eb"), Type = TextBlockType.Text, Text = $"You dart under the legs of your enemies in combat. You can end a successful {ToMarkdownLink<Models.Entities.SkillAction>("Tumble Through", SkillActions.Instances.TumbleThrough.ID)} action in a Large or larger enemy's space. Also, when using the {ToMarkdownLink<Models.Entities.Feat>("Step Lively", Feats.Instances.StepLively.ID)} feat, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} into the triggering enemy's space. The enemy must have limbs or otherwise leave you enough room for this maneuver, as determined by the GM. For instance, you could share space with a giant or dragon, but not an ooze." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3f914fee-2f95-4890-a5c0-3246e71aa3ba"), Feats.Instances.StepLively.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2582005-57af-4c50-821f-279dfdc17932"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
