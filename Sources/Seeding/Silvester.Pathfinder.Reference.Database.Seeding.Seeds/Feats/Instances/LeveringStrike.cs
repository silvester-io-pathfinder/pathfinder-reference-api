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
    public class LeveringStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("25a339f9-f4ca-4425-86ef-a41339e9a0a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Levering Strike",
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
            yield return new TextBlock { Id = Guid.Parse("a8c7216d-866f-496c-aa44-ca82d5540775"), Type = TextBlockType.Text, Text = $"Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your staff. As long as you don't critically fail, the target becomes flat-footed and takes a -2 circumstance penalty to its DC against {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}, and {ToMarkdownLink<Models.Entities.SkillAction>("Tumble Through", SkillActions.Instances.TumbleThrough.ID)} attempts until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("508d61c9-34f0-4e4e-85e9-41e4d28f7702"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bee7ec1f-0960-4489-be73-b4c18afce1ca"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
