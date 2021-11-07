using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineAccess : Template
    {
        public static readonly Guid ID = Guid.Parse("7c7bd492-6076-4ba1-acdc-875c2a66f9fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Access",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. You can't choose the same spells more than once, but you can choose a different domain or a different deity with the same domain you've previously selected with this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28128974-7dcf-4ba1-9c5a-feb6b962e0ae"), Type = TextBlockType.Text, Text = "Your ability to tap into divine magic surpasses the spells traditionally available to you (the divine spell list). Choose one deity who grants one of your mystery’s granted domains. Add up to three cleric spells of your choice granted by that deity to your spell list. You can select from these spells when you add or swap spells in your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9a122d7-10ec-426f-9c4c-82016048a5ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
