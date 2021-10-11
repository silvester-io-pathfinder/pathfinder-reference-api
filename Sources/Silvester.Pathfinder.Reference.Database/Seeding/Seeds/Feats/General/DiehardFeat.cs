using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class DiehardFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("15ccc079-da12-4678-8b48-f626e51418df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diehard",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49a1d867-7420-4c1d-9c70-3b36f83adf22"), Type = Utilities.Text.TextBlockType.Text, Text = "It takes more to kill you than most. You die from the dying condition at dying 5, rather than dying 4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ebab1dd-5185-4a90-9275-7810f6a577eb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 260
            };
        }
    }
}
