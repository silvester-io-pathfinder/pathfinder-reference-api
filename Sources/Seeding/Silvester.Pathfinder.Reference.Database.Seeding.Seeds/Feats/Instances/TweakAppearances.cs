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
    public class TweakAppearances : Template
    {
        public static readonly Guid ID = Guid.Parse("1a320e85-b571-4a6f-b953-f9601ebfdf0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tweak Appearances",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b033722-04e9-4b62-b6d5-87f3d078cd28"), Type = TextBlockType.Text, Text = $"~ Access: Have earnt Mialari Docur's trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("5947fcc3-75d2-4412-a052-001113f1eb4d"), Type = TextBlockType.Text, Text = $"You spend 1 minute making quick adjustments to someone's clothing and appearance, causing their words to carry more weight with an audience of your choice." };
            yield return new TextBlock { Id = Guid.Parse("20f8bfdf-f226-4c12-91e2-e628cc1be190"), Type = TextBlockType.Text, Text = $"While speaking to that audience, the target gains a +1 item bonus to Diplomacy and Performance checks. If you have master proficiency in Crafting, the bonus increases to +2; if you have legendary proficiency in Crafting, the bonus increases to +3. This bonus lasts until this ability is used on the target again, the situation they were prepared for ends, or they next change their outfit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d76fa732-d329-4f53-9a5c-fa57abb136ba"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abb081c4-09ab-407e-9c23-c26c42b7bd1d"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
