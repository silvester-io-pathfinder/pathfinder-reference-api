using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("4e2d6e32-ad33-4778-9290-1f23ffcdcfa8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Vengeance",
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
            yield return new TextBlock { Id = Guid.Parse("1dffa5e9-accc-4ee1-ae3e-97ff2791b76d"), Type = TextBlockType.Text, Text = "~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("1918a94e-e427-4c78-98b8-3b4754204813"), Type = TextBlockType.Text, Text = "You gain the (spell: needle of vengeance) hex, and your familiar learns (spell: phantom pain)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d70f4994-5d6f-4898-97bf-30c7a6efe931"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
