using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("ef9a2276-cc2a-477b-959a-60fb79b3023a");

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
            yield return new TextBlock { Id = Guid.Parse("2bab715d-0eda-42ed-8406-51b1f662036f"), Type = TextBlockType.Text, Text = $"You imprint a bullet with a field of abjuration built upon your magical signature, disrupting the magic of whatever it hits. Make a firearm or crossbow {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe you can see. If you hit, you attempt to counteract a spell effect active on the target (your choice, or the highest-level effect if you don't choose). Your counteract level is equal to half your level (rounded up), and your counteract check modifier is equal to your class DC – 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8dbc5864-f149-4c3d-94c3-52cfe185e75e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
