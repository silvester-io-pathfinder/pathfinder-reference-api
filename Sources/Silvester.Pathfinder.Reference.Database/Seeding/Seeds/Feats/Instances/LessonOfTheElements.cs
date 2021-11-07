using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfTheElements : Template
    {
        public static readonly Guid ID = Guid.Parse("5611b030-9f5a-4a29-87ef-4969f20bc6be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of the Elements",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ace73c78-fbf1-4cc9-99a4-efaadc47fab1"), Type = TextBlockType.Text, Text = "~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("5c222494-d459-41bb-b380-09e99ae1e808"), Type = TextBlockType.Text, Text = "You gain the (spell: elemental betrayal) hex. Your familiar learns your choice of (spell: burning hands), (spell: air bubble), (spell: hydraulic push), or (spell: pummeling rubble)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("664a0b30-de0d-463f-9596-f5631607e426"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
