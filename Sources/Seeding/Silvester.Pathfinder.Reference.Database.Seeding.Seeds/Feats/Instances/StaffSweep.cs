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
    public class StaffSweep : Template
    {
        public static readonly Guid ID = Guid.Parse("68ab28e5-d0e5-4d71-be01-d2651517ac29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Staff Sweep",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbb83e34-b996-482c-a4a5-b1fb4cb4507f"), Type = TextBlockType.Text, Text = $"You sweep your foes away with your staff. Roll an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}, and compare the result to the appropriate DCs of up to two foes, each of whom must be within your reach and no more than 5 feet apart." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8492ea7e-d6e2-4b66-a65f-6ccb6d7ea2e1"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("40256088-6caa-449f-83f6-2a2772c0260b"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("79d38a01-c4d9-456d-a015-ae98e12fd631"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("560226d2-a959-42c0-bf69-38e472221fb0"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
