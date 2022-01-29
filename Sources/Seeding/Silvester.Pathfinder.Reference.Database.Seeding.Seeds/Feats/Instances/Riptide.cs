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
    public class Riptide : Template
    {
        public static readonly Guid ID = Guid.Parse("fcfc2d42-b4a9-4c5c-8915-a09b1c65b22c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Riptide",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Grapple a creature of the same size as you or smaller.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("99c8caad-2e7e-48fd-8efd-7fe787f31584"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to 10 feet to enter the water, bringing the grabbed creature with you into the water." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8756684e-5aff-44e9-8793-3a008c482e53"), Feats.Instances.DragDown.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("44d20644-7a9a-42b8-97b1-cdfe888504e8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a839eafa-9045-4b5b-af25-78e3ecfb7eef"), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf459cc4-c377-4868-a2ed-4be57821a758"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
