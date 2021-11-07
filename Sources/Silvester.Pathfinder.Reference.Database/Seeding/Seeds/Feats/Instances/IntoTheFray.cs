using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntoTheFray : Template
    {
        public static readonly Guid ID = Guid.Parse("0d796075-a257-42fb-b1c1-1c8e249558c5");

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
            yield return new TextBlock { Id = Guid.Parse("cd2fb99e-66bd-489a-9db0-820d1f5a9e8f"), Type = TextBlockType.Text, Text = "You know trouble can lurk around every corner, and your hands never stray far from your holsters. You can (action: Interact) to draw a one-handed ranged weapon and can then (action: Interact) to draw a one-handed melee weapon. As your first action on your first turn, you can (action: Stride) as a free action toward an enemy you can perceive. If you can’t perceive any enemies or can’t end your movement closer to one, you can’t use this (action: Stride)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("343c934c-6084-4d24-8985-47b57dd70dbb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
