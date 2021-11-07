using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenaciousNet : Template
    {
        public static readonly Guid ID = Guid.Parse("9be1d367-eeff-41d0-b9b9-60eb6738fa24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tenacious Net",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6a289a0-3b04-4db3-ade4-f632e9d53d3c"), Type = TextBlockType.Text, Text = "Escaping your nets is no simple task. The Athletics DC to (action: Force Open) or (action: Escape) your nets increases from 16 to 18. After a creature you grabbed with a (item: net) (action: Escapes | Escape) or (action: Forces Open | Force Open) the net, stray strands of the net cling to the creature, causing them to remain flat-footed until the beginning of their next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54608023-f37f-4441-a039-9ad924280b84"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
