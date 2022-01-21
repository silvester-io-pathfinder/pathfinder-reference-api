using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Crusade : Template
    {
        public static readonly Guid ID = Guid.Parse("e4568cde-13d1-4684-81b2-180bc291198f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Crusade",
                Level = 9,
                Range = "60 feet.",
                Targets = "Up to 4 creatures.",
                Duration = "4 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df3cba14-93f8-43ef-b3fa-076419919259"), Type = Utilities.Text.TextBlockType.Text, Text = "You issue a divine mandate or proclaim a cause to the targets. It can be to attain an item, claim a patch of land, slay a creature, war with a group, or be entirely peaceful. Your cause can't force the targets to harm one another or themselves. The targets become completely dedicated to that cause, depending on their levels. They choose their own actions, but they favor direct action over inaction or indirect action." };
            yield return new TextBlock { Id = Guid.Parse("9e535072-b4b7-428e-94c3-898de6ca0ab6"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "13th or Lower: The target is so dedicated to the cause that it pursues the cause to the death (unless you say otherwise)." };
            yield return new TextBlock { Id = Guid.Parse("45983a64-0a25-4eba-9eaf-d050a4b49d11"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "14th: The target is dedicated to the cause, but the spell ends for the target if it's reduced to half its maximum Hit Points or fewer." };
            yield return new TextBlock { Id = Guid.Parse("f3e7e74b-556d-46f8-87fe-861544c2331b"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "15th: As 14th, plus the target can attempt a Will save at the end of each of its turns to end the spell for itself." };
            yield return new TextBlock { Id = Guid.Parse("c474670c-dd98-40b0-a6fc-f5d19f51fec1"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell ends for all creatures if you or one of your allies uses a hostile action against a target, or when the cause is completed. The GM might determine this spell has alignment traits befitting the cause." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("7c4a2e8b-867f-4b2b-816a-535e3eb0fc79"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8f48fd63-265e-421f-9393-46220ae44b5c"), Type = Utilities.Text.TextBlockType.Text, Text = "The level for each category increases by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7d59df7a-fc89-477e-aecc-f11c6a555705"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f301d35e-44ba-44f9-8126-f4333d718060"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("837b99fe-dbb4-48da-a1a1-125bb6ded8da"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("7a461148-2cff-4867-864d-304bd7283d95"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd33f64-1166-4660-8cba-2d87a234f609"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
