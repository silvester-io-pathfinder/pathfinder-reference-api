using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("16aa28ca-a28f-4a40-8eab-6d215123cffe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shift Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66baa1aa-79a8-4f52-9932-21c5bb66b190"), Type = TextBlockType.Text, Text = "~ Access: member of the Magaambya" };
            yield return new TextBlock { Id = Guid.Parse("dd4a3291-bcf6-4f3f-8082-0fca86e8a67c"), Type = TextBlockType.Text, Text = "You move the spell&#39;s area to a new location within 120 feet. The spell&#39;s remaining duration is reduced by half. The spell no longer affects its previous area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d876ac4-012d-4e31-bb4d-04018fdbd54b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
