using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LiveAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("a967730d-9a60-47ba-bd7d-4c08d7cde206");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Live Ammunition",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4905e972-ad6a-4209-80d3-2fde3d0d7c42"), Type = TextBlockType.Text, Text = "There are generally few things as ill-advised as being shot out of a cannon or launched by a trebuchet, but people use the tactic every so often in a desperate situation. While it’s more humane to use this strategy with mindless constructs or undead, occasionally an exceedingly foolhardy adventurer demands the opportunity to try it. Loading a creature requires two additional Load actions, which you must conduct personally. The creature must be willing, unconscious, or restrained throughout the process, and the siege weapon must be physically capable of firing the creature in question, based on their size and shape. Typically, that means ballistas don’t qualify, for example—nor do auto-catapults which require specifically-sized balls—but normal catapults and onagers work just fine. When you Launch the weapon, if the weapon usually targets an area, you target a single 5-foot square instead. The siege weapon deals its normal damage to its target, or to the modified area, and to the creature fired." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5d6757e-5763-47d6-b356-3e8651ab594f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
