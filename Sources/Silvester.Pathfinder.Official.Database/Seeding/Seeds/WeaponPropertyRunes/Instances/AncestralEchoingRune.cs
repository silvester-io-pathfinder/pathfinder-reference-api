using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class AncestralEchoingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("694dff71-27b6-4641-8067-858ddb50f978");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Ancestral Echoing",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("8faff1df-7d66-4cbc-9528-2cf973fedf10"),
                ItemLevel = 15,
                Price = 950000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("e337a626-4b09-4e8c-9bb1-28cc5f89335b"), Type = TextBlockType.Text, Text = "The wisdom of this weapon’s past owners flows into your mind, amplifying your own abilities with the weapon. Your proficiency rank with this weapon is one step higher than normal, to a maximum of the highest proficiency rank you have in any weapon. For instance, if you had master proficieny with martial weapons and expert proficiency with advanced weapons, you would have master proficiency with advanced weapon that had this rune."},
                    new TextBlock {Id = Guid.Parse("bc8e78cc-7535-4e8e-9e8a-59da36aa6076"), Type = TextBlockType.Text, Text = "In addition, while wielding the ancestral echoing weapon, you have expert proficiency in one Lore skill relevant to one or more of the weapon’s previous owners. This is typically Dwarven Lore but is ultimately determined by the GM depending on the weapon’s history."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Saggorak.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb181177-dc37-4a68-b72a-8210b8fb34ef"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
