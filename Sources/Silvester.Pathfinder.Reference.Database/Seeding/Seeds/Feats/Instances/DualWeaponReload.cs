using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualWeaponReload : Template
    {
        public static readonly Guid ID = Guid.Parse("6791a8c5-1b73-4b23-8ce2-efd3c21161b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Weapon Reload",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed5a7988-210f-4d8e-833c-a8637023be87"), Type = TextBlockType.Text, Text = "You carry your ammunition in a way that allows you to reload while holding two weapons. You (action: Interact) to reload a one-handed ranged weapon you’re holding. Unlike most (action: Interact) actions, you don’t need a free hand to reload your ranged weapon in this way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f696e2aa-c838-4492-b932-1bcc6a9b3c96"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
