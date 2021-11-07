using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostShot : Template
    {
        public static readonly Guid ID = Guid.Parse("1c58d66f-cd1a-4dbd-934d-d018eaae3186");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b186b5e-4eef-4b1c-ae03-3c6e77aa8dde"), Type = TextBlockType.Text, Text = "Make a firearm or crossbow (action: Strike). If you’re hidden from or undetected by the target, the (action: Strike) adds the additional precision damage from (feat: One Shot, One Kill); if you would already receive that additional damage on the (action: Strike), the effects aren’t cumulative. If you were undetected or unnoticed by any creatures, you’re now hidden from them instead, as the origin of the attack is clear." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5664dc28-49a0-413b-902e-812b7fd67840"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
