using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellspringGnomeArcane : Template
    {
        public static readonly Guid ID = Guid.Parse("02be9bc4-582a-450e-981e-32898cf5a0db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wellspring Gnome - Arcane",
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
            yield return new TextBlock { Id = Guid.Parse("39b266c6-5af2-423a-a438-b3d68a3cdad2"), Type = TextBlockType.Text, Text = "You gain one cantrip from the arcane spell list. You can cast this spell as an innate spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("089ab149-d9ff-4b25-98b9-2f243a4ad2af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
