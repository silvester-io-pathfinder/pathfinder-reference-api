using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineAccess : Template
    {
        public static readonly Guid ID = Guid.Parse("217bc64a-514e-4fbf-a4c1-cd4fc23d6d03");

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
            yield return new TextBlock { Id = Guid.Parse("c650e1d1-dcae-4175-b3df-fac7be844056"), Type = TextBlockType.Text, Text = "Your ability to tap into divine magic surpasses the spells traditionally available to you (the divine spell list). Choose one deity who grants one of your mystery's granted domains. Add up to three cleric spells of your choice granted by that deity to your spell list. You can select from these spells when you add or swap spells in your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceeeb97e-8f23-4182-9a4d-80c1ef8077b0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
