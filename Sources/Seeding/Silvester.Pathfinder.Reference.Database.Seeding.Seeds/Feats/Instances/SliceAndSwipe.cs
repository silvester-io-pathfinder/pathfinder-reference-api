using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SliceAndSwipe : Template
    {
        public static readonly Guid ID = Guid.Parse("b184bc1a-73ce-4cee-a5fb-0140b90ff8af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slice and Swipe",
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
            yield return new TextBlock { Id = Guid.Parse("80ea0dc5-957e-49e9-9d55-9f3c9b617144"), Type = TextBlockType.Text, Text = $"~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("070fdf66-a746-47c3-a55b-cc27b95c1440"), Type = TextBlockType.Text, Text = $"You attempt a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. If you hit and deal damage and the result of your attack roll exceeds the target's Perception DC, you {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} a small object from the target (as if you had succeeded at that task using the Thievery skill). Depending on the object, the target might realize that it has been stolen, and onlookers might realize you have stolen the object if the attack roll doesn't exceed their Perception DCs." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49768579-149d-48c5-a2d1-462e160a3404"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
