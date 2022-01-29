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
    public class EnergizedFont : Template
    {
        public static readonly Guid ID = Guid.Parse("6d928f4b-63ab-4a40-a710-a97e3cccd134");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energized Font",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a25642ef-4765-4ee8-9d3d-fecec750429a"), Type = TextBlockType.Text, Text = $"The magic within you provides increased energy you can use to focus. You regain 1 Focus Point, up to your usual maximum." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("4bedfb44-a3eb-42da-8f35-25c527e8fc2b"));
            builder.Manual(Guid.Parse("23e101b7-188a-4ec6-94ce-5337caae1778"), "At least one innate spell from a gonome heritage or ancestry feat that shares a tradition with at least one of your focus spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d40fa188-235b-4d59-b4a0-5f73149daa69"), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f69fecf3-0690-4775-befc-b9504f4cf383"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
