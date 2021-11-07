using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyFamiliarSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("7699a37e-3422-40f6-bf0f-f1b52f31cae4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leshy Familiar Secrets",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("858fd4dd-8bb2-45c2-b646-03075cfe56f6"), Type = TextBlockType.Text, Text = "The leaf order’s secrets allow your familiar to take advantage of its leshy form. You can select one additional familiar ability each day, which must be one of the following leshy familiar abilities. You can’t select more than one leshy familiar ability at a time." };
            yield return new TextBlock { Id = Guid.Parse("2a71063f-aad5-47d5-81b6-16dd2243aeda"), Type = TextBlockType.Enumeration, Text = " Grasping Tendrils: Your familiar can extend vines or similar tendrils, increasing its reach to 15 feet." };
            yield return new TextBlock { Id = Guid.Parse("e1c2a6dd-62b7-4cac-a44f-5e82fc8979c6"), Type = TextBlockType.Enumeration, Text = " Purify Air: Your familiar recycles air, providing enough oxygen for a Medium creature in areas with stale air, such as a sealed chamber or extradimensional space. If the leshy is within the area of an (trait: inhaled) poison effect or an effect that relies on smell, creatures within a 15-foot emanation from the leshy gain a +2 circumstance bonus to their saving throws against the effect." };
            yield return new TextBlock { Id = Guid.Parse("9ea2f5a8-ddec-4b84-a49d-41efac881f31"), Type = TextBlockType.Enumeration, Text = " Verdant Burst:  When your familiar dies, it releases its primal energy to cast the 3-action version of (spell: heal), heightened to a level 1 lower than your highest-level spell slot. The (spell: heal) spell gains a status bonus equal to twice the spell’s level to the Hit Points it restores to plants. You must be able to cast 2nd-level spells using spell slots to select this familiar ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("ed446ba2-d3d7-443d-b914-0d4bed97332f"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a0ac996-6468-47dc-90f1-f7f9bd8999c2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
