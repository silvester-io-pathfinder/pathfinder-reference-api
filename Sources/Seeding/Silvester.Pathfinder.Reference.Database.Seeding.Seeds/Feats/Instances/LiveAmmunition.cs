using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LiveAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("adb33e3b-7601-4525-921f-06aef2b3bbf8");

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
            yield return new TextBlock { Id = Guid.Parse("ff6cc4e1-860b-4d18-bb65-dd8f0062a64f"), Type = TextBlockType.Text, Text = $"There are generally few things as ill-advised as being shot out of a cannon or launched by a trebuchet, but people use the tactic every so often in a desperate situation. While it's more humane to use this strategy with mindless constructs or undead, occasionally an exceedingly foolhardy adventurer demands the opportunity to try it. Loading a creature requires two additional Load actions, which you must conduct personally. The creature must be willing, unconscious, or restrained throughout the process, and the siege weapon must be physically capable of firing the creature in question, based on their size and shape. Typically, that means ballistas don't qualify, for example—nor do auto-catapults which require specifically-sized balls—but normal catapults and onagers work just fine. When you Launch the weapon, if the weapon usually targets an area, you target a single 5-foot square instead. The siege weapon deals its normal damage to its target, or to the modified area, and to the creature fired." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5867b27-81b1-4377-a8b4-2eb743c18799"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
