using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToxicSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("9ec023e9-703d-4e1e-9ed4-92ffe5f4eef7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Toxic Skin",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature touches you, such as by Grappling you, successfully hitting you with an unarmed attack, or using a touch-range spell against you.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fe870c1-29fd-4589-b8c5-396a324c70ae"), Type = TextBlockType.Text, Text = "You exude a deadly toxin. The triggering creature takes 1d4 poison damage (basic Fortitude save using your class DC or spell DC, whichever is higher). At 3rd level and every 2 levels thereafter, the damage increases by 1d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9a8546b-d4b7-4e31-bf07-05deb5e082e5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
