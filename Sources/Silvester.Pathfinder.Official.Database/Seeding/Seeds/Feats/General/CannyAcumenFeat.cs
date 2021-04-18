using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CannyAcumenFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("85740fcc-7aaf-494f-81d7-8360620977d1"),
                Name = "Canny Acumen",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f69671b-1e75-49a2-b6a8-d418bbf60f3f"), Type = Utilities.Text.TextBlockType.Text, Text = "Your avoidance or observation is beyond the ken of most in your profession. Choose Fortitude saves, Reflex saves, Will saves, or Perception. You become an expert in your choice. At 17th level, you become a master in your choice." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Downtime";
            yield return "General";
            yield return "Skill";
        }
    }
}
