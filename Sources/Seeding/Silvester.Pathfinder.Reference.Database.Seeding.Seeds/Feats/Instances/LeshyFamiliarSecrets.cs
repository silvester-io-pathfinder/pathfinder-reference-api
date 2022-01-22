using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyFamiliarSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("b9bcf4c8-aadb-4df0-997f-6bab1dfe96b8");

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
            yield return new TextBlock { Id = Guid.Parse("185e9393-c96a-4ea0-b3ca-d6e29ba718ea"), Type = TextBlockType.Text, Text = $"The leaf order's secrets allow your familiar to take advantage of its leshy form. You can select one additional familiar ability each day, which must be one of the following leshy familiar abilities. You can't select more than one leshy familiar ability at a time." };
            yield return new TextBlock { Id = Guid.Parse("799414bf-fc58-44c7-9c1a-eb88de783111"), Type = TextBlockType.Enumeration, Text = $" Grasping Tendrils: Your familiar can extend vines or similar tendrils, increasing its reach to 15 feet." };
            yield return new TextBlock { Id = Guid.Parse("fdf05c3d-b3ec-4ee4-a783-3bee3e3a4b4c"), Type = TextBlockType.Enumeration, Text = $" Purify Air: Your familiar recycles air, providing enough oxygen for a Medium creature in areas with stale air, such as a sealed chamber or extradimensional space. If the leshy is within the area of an {ToMarkdownLink<Models.Entities.Trait>("inhaled", Traits.Instances.Inhaled.ID)} poison effect or an effect that relies on smell, creatures within a 15-foot emanation from the leshy gain a +2 circumstance bonus to their saving throws against the effect." };
            yield return new TextBlock { Id = Guid.Parse("0e7ddeec-dcdd-4f36-94cd-e420af8da879"), Type = TextBlockType.Enumeration, Text = $" Verdant Burst:  When your familiar dies, it releases its primal energy to cast the 3-action version of {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)}, heightened to a level 1 lower than your highest-level spell slot. The {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell gains a status bonus equal to twice the spell's level to the Hit Points it restores to plants. You must be able to cast 2nd-level spells using spell slots to select this familiar ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("7f46d9b5-5d5e-4a46-bbbc-70921f37e2ba"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("638ea4c9-b1e7-41db-b069-413eddd1601d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
