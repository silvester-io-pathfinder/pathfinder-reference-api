using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToxicSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("11653361-a781-4534-90fb-22930f47293e");

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
            yield return new TextBlock { Id = Guid.Parse("f7646d1e-85b3-4613-bfd2-500d9e4f3119"), Type = TextBlockType.Text, Text = $"You exude a deadly toxin. The triggering creature takes 1d4 poison damage (basic Fortitude save using your class DC or spell DC, whichever is higher). At 3rd level and every 2 levels thereafter, the damage increases by 1d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb64fa03-0ad8-48c1-921f-7db2f426cf90"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
