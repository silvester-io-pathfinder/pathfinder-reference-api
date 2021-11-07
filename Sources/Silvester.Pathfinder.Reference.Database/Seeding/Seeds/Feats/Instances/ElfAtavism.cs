using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElfAtavism : Template
    {
        public static readonly Guid ID = Guid.Parse("f0d40776-5a7f-4256-afb2-e52c55b39074");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elf Atavism",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7df9f4e3-5f2b-41a2-afa0-3d7c640dfd8b"), Type = TextBlockType.Text, Text = "Your elven blood runs particularly strong, granting you features far more elven than those of a typical half-elf. You may also have been raised among elves, steeped in your elven ancestors’ heritage. You gain the benefits of the elf heritage of your elven parent or ancestors. You typically can’t select a heritage that depends on or improves an elven feature you don’t have. For example, you couldn’t gain the cavern elf’s darkvision ability if you didn’t have low-light vision. In these cases, at the GM’s discretion, you might gain a different benefit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2a695bf-f89f-4af9-9cce-c473f0ac85b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
