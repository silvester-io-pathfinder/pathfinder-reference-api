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
    public class PivotStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("a714a3ba-e3fd-4592-ac27-3586a2ae9184");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pivot Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e6a73b4-5342-4e09-bfad-cc70831dfc54"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} using your staff. You gain a circumstance bonus to damage for the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} equal to twice the number of weapon damage dice. Regardless of whether your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hit, you can then attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5cee3654-f2c3-4238-9d94-d59653aac067"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de0b7f4f-c055-42bb-94b7-f83d1846a3b4"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
