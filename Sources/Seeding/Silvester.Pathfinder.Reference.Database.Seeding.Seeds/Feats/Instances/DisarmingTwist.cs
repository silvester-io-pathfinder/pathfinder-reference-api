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
    public class DisarmingTwist : Template
    {
        public static readonly Guid ID = Guid.Parse("85752ce5-0296-4c3a-83bf-91f36a74535a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Twist",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70ae409b-2a2e-4f75-9d69-3cfad9d828c1"), Type = TextBlockType.Text, Text = $"After your initial attack redirects your foe's defenses, your follow-up wrests their weapon from their grasp. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. In addition to its other effects, this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} gains the success and critical success effects of the {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} action. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} also has the following failure effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b5adb8d0-e395-40f1-ae31-5004ca4f885a"), Feats.Instances.DuelistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("424cb9a2-aa08-4e7e-be92-8fad530293ef"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e15e6217-198d-4f29-b853-f0bbd8d702c6"),
                
                
                Failure = "The target is flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd0bedc6-1ef0-480b-a249-4bddedb1c2b9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
