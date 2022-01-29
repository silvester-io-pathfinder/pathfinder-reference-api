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
    public class LostInTheCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("5a9ec21b-462a-45a0-abad-0bcc635b8e30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lost in the Crowd",
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
            yield return new TextBlock { Id = Guid.Parse("d3522f09-d48d-49ca-8739-88577c74912c"), Type = TextBlockType.Text, Text = $"You've learned how to move as one with crowds and hide among them, vanishing into a busy street in the blink of an eye. You move at full Speed in crowds and can use cover from crowds to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)}, gaining a +2 circumstance bonus on your Stealth checks when in a crowd of at least 10 creatures and a +4 circumstance bonus on your Stealth checks when in a crowd of at least 100 creatures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f2f73206-8a16-4795-a5fe-66ccae4e8c59"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("cecfaad6-b09d-41c1-89b6-31606b912775"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cdbadd78-2d06-4988-8145-d7bd5f9f2877"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
