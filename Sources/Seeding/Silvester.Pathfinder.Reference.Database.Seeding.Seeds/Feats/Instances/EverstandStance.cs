using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverstandStance : Template
    {
        public static readonly Guid ID = Guid.Parse("48c89e29-ccae-40f4-a0de-eda16916fca0");

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
            yield return new TextBlock { Id = Guid.Parse("d409cad0-a67e-468d-a648-ad348b2a1bb4"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("d53ae76e-b8f3-4751-a350-fff1afd55a4c"), Type = TextBlockType.Text, Text = "You brace your shield with both hands, enhancing its potential for both offense and defense. When in this stance, you wield the shield with both hands. When wielding a shield this way, increase the weapon damage die of the shield's boss or spikes by one step, and increase the shield's Hardness by 2 when using the (feat: Shield Block) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c262557c-e1bb-4b36-93a1-1220b1d8da65"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}