using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("0ea4f13b-08e8-4d79-9774-b84e8265fe3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smoke Bomb",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb with a level at least 1 lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("178d210d-123a-44bc-8150-949ad6d48818"), Type = TextBlockType.Text, Text = "You cause the bomb to create a cloud of thick smoke, in addition to its normal effects. When thrown, the bomb creates a cloud of smoke in a 10-foot-radius burst. You choose which corner of the target’s space (or the space in which the bomb lands) the cloud is centered on. Creatures within that area have the concealed condition, and all other creatures are concealed to them. The smoke lasts for 1 minute or until dissipated by a strong wind." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc479350-36fd-47bf-8522-dff12f22a7d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
