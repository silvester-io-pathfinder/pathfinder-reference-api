using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Bristle : Template
    {
        public static readonly Guid ID = Guid.Parse("38fad89a-9e06-4650-a30d-0a1ed1281537");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bristle",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Barbed Quills) reaction or a quills unarmed attack, each gains a +1 circumstance bonus to damage rolls until the start of your next turn.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79438497-0840-45d0-920c-192e124ed5ea"), Type = TextBlockType.Text, Text = $"You curl into a posture that splays out your bone spines. You gain a +1 circumstance to AC until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("560c588b-da44-49ed-8947-af2c48170ce5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
