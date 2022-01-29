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
    public class WalkThePlank : Template
    {
        public static readonly Guid ID = Guid.Parse("ad98b5e0-d8b6-400a-922b-fb5997e5500e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Walk the Plank",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e27f420e-2ffa-4708-af4b-de12692e19bd"), Type = TextBlockType.Text, Text = $"You frighten a foe into moving where you want them, traditionally demanding they walk the plank. Attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} an opponent; this check gains the {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} trait. On a success, in addition to the normal effects, you can also force the target to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to its Speed. You choose the path the target takes, and it does so as part of your Walk the Plank action. You can't force the target to move into a harmful space (one where it will take damage, fall, provoke reactions, or similar) unless the result of your check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} was a critical success. The target then becomes temporarily immune to Walk the Plank for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c2a6f068-e169-4831-8e71-4190722aeb11"), Feats.Instances.PirateDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd87749f-2e3a-436b-8961-4af1ea28863e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
