using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MightyRage : Template
    {
        public static readonly Guid ID = Guid.Parse("f74df492-aa27-4b32-a484-3cdb55741f45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mighty Rage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use the Rage action on your turn.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbe5a4e0-c828-4e61-8225-0ac074d0aa38"), Type = TextBlockType.Text, Text = "Use an action that has the (trait: rage) trait. Alternatively, you can increase the actions of the triggering (feat: Rage) to 2 to instead use a 2-action activity with the (trait: rage) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("779270dc-31b3-4bef-8a4f-fb5f13a1c103"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
