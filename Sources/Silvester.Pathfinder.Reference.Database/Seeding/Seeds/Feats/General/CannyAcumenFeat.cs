using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CannyAcumenFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("85740fcc-7aaf-494f-81d7-8360620977d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f69671b-1e75-49a2-b6a8-d418bbf60f3f"), Type = Utilities.Text.TextBlockType.Text, Text = "Your avoidance or observation is beyond the ken of most in your profession. Choose Fortitude saves, Reflex saves, Will saves, or Perception. You become an expert in your choice. At 17th level, you become a master in your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f24fb127-2f4f-4ded-b0ec-e5f366a7b7d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 259
            };
        }
    }
}
