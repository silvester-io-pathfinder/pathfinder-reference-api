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
    public class SpringingLeaper : Template
    {
        public static readonly Guid ID = Guid.Parse("a3ccd59f-7048-41e3-b523-c58d5b188c77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Springing Leaper",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1aa06c8-ef2a-4f98-a573-de30b99d20e2"), Type = TextBlockType.Text, Text = $"Your powerful legs allow you to make sudden and dramatic leaps. You can {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} as a 2-action activity to double the distance you can {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} vertically, or {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} as a 3-action activity to triple the distance you can {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} vertically. You don't automatically fail {ToMarkdownLink<Models.Entities.SkillAction>("Long Jumps", SkillActions.Instances.LongJump.ID)} for jumping in a different direction than your {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("56685835-f86a-4fb7-946e-864d3c965350"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Catfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f56d95d0-fcb9-420f-b928-ea294a76adde"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
