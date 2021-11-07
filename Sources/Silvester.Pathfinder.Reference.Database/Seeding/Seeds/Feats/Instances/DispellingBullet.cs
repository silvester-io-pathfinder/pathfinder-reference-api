using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("9a6ca4dd-16f3-4d12-827f-f2ffdf70890b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dispelling Bullet",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a26e8a32-8b99-4e8d-a926-765d4534ef13"), Type = TextBlockType.Text, Text = "You imprint a bullet with a field of abjuration built upon your magical signature, disrupting the magic of whatever it hits. Make a firearm or crossbow (action: Strike) against a foe you can see. If you hit, you attempt to counteract a spell effect active on the target (your choice, or the highest-level effect if you don’t choose). Your counteract level is equal to half your level (rounded up), and your counteract check modifier is equal to your class DC – 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ede101c-c086-4637-80af-62ffc9faef2a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
