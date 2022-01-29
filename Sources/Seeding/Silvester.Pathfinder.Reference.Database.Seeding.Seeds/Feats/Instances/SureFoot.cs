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
    public class SureFoot : Template
    {
        public static readonly Guid ID = Guid.Parse("ebcaf82b-db00-4caa-9c0c-d66f82c3378a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sure Foot",
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
            yield return new TextBlock { Id = Guid.Parse("8d4755f4-9275-42bb-af73-34b6f679070e"), Type = TextBlockType.Text, Text = $"You know the secrets of moving in your favored terrain. You gain a +2 circumstance bonus to skill checks to move within your favored terrain, such as Acrobatics checks to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)} on ice, Athletics checks to {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)} in rough water, Acrobatics checks to {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)} in windy conditions, and so forth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9da9f7e5-7102-488f-a425-22b677514305"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3d101478-6cf4-45da-b189-94c9bc81be15"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("60f8e34b-b724-4425-9700-7d5d99c1cac8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("edb950ca-acde-4443-9682-f690c643e84a"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("fa399da4-339c-4a6d-9084-6f38d0f0a179"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fabd86a7-c342-4a34-a743-24104a709765"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
