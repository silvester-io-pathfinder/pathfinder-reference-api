using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PositiveLuminance : Template
    {
        public static readonly Guid ID = Guid.Parse("d2439bc1-10f4-48d4-859c-bbc9ba5c7acd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Positive Luminance",
                Level = 4,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Sun.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98c8deed-43b8-474a-a0f6-254a49a7bc45"), Type = TextBlockType.Text, Text = "Drawing life force into yourself, you become a beacon of positive energy. You glow with bright light in a 10-foot emanation, and you gain an internal pool of light called a luminance reservoir, which begins with a value of 4. At the start of each of your turns, you can use a free action to increase the luminance reservoir by 4. If you do, the radius of your light increases by 10 feet." };
            yield return new TextBlock { Id = Guid.Parse("3452cac0-7512-4ff3-9ce4-7bd150f1714a"), Type = TextBlockType.Text, Text = "If an undead creature damages you with an attack or spell while it’s within the area of your light, that creature takes positive damage equal to half your luminance reservoir value. It takes this damage only the first time it damages you in a round." };
            yield return new TextBlock { Id = Guid.Parse("a344aa7c-8122-43d1-9601-deae344cbc16"), Type = TextBlockType.Text, Text = "You can Dismiss this Spell. When you do, you can target a creature within your light and direct the positive energy into it. The target must be a willing living creature or an undead creature. This heals a living target or damages an undead target by an amount equal to your luminance reservoir’s value." };
            yield return new TextBlock { Id = Guid.Parse("5f7f9bcd-1a9b-47bc-bfb2-4d464da4217f"), Type = TextBlockType.Text, Text = "When you cast positive luminance, any other positive luminance spell you already had in effect ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5a1e3510-759d-4e5b-bdd8-78958ddda0c7"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c1b25f93-b7ae-44f8-ab5c-ff06dd67afbc"), Type = TextBlockType.Text, Text = "Both the initial value of your luminance reservoir and the amount you gain each turn increase by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7590c55b-526b-40bb-892e-b3b9cf5b7512"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
