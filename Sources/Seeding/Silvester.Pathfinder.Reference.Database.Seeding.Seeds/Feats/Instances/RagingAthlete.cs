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
    public class RagingAthlete : Template
    {
        public static readonly Guid ID = Guid.Parse("fcfdc11d-0c15-498d-890e-25404075afe7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Athlete",
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
            yield return new TextBlock { Id = Guid.Parse("59373aed-e066-43f7-85ce-691e58b72897"), Type = TextBlockType.Text, Text = $"Physical obstacles can't hold back your fury. While you are raging, you gain a climb Speed and swim Speed equal to your land Speed and the DC of {ToMarkdownLink<Models.Entities.SkillAction>("High Jumps", SkillActions.Instances.HighJump.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Long Jumps", SkillActions.Instances.LongJump.ID)} decreases by 10. Your distance for a vertical {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} increases to 5 feet vertically, and your distance for a horizontal {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} increases to 15 feet if your Speed is at least 15 feet and to 20 feet if your Speed is at least 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4bffb56e-1850-4359-b319-2eb926a91438"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("016e5e21-533e-4580-b04a-09f48d332216"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
