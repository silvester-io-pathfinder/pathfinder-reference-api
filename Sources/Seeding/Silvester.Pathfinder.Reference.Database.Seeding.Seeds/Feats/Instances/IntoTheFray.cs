using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntoTheFray : Template
    {
        public static readonly Guid ID = Guid.Parse("df01069f-bfd8-44ab-86fe-648e23ba44db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Into the Fray",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ea58467-3a0e-4082-bfb3-995bc7f7e03c"), Type = TextBlockType.Text, Text = "You know trouble can lurk around every corner, and your hands never stray far from your holsters. You can (action: Interact) to draw a one-handed ranged weapon and can then (action: Interact) to draw a one-handed melee weapon. As your first action on your first turn, you can (action: Stride) as a free action toward an enemy you can perceive. If you can't perceive any enemies or can't end your movement closer to one, you can't use this (action: Stride)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82318d77-72de-4acb-8675-8c738438a940"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
