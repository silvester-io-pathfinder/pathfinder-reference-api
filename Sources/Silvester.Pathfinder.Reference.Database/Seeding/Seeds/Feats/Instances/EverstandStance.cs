using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverstandStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c0be59fb-2bdb-4262-80ac-9cac08f5c058");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everstand Stance",
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
            yield return new TextBlock { Id = Guid.Parse("ae910bda-2dc0-4cc4-b0de-94936633e105"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("fc4981e2-ad12-4c5d-9ab0-5a0b86b55184"), Type = TextBlockType.Text, Text = "You brace your shield with both hands, enhancing its potential for both offense and defense. When in this stance, you wield the shield with both hands. When wielding a shield this way, increase the weapon damage die of the shield’s boss or spikes by one step, and increase the shield’s Hardness by 2 when using the (feat: Shield Block) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a175156-6e42-436c-8870-8ab779513644"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
