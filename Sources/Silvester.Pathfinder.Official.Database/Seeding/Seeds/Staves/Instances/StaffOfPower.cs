using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfPower : Template
    {
        public static readonly Guid ID = Guid.Parse("06990eb6-99e6-4f28-a33c-dc1eadd99cf6");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Power",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("37ba2630-5ba5-49da-9af1-c5d9d555f2db"), Type = TextBlockType.Text, Text = "This staff of magically hardened wood is topped with a silver sculpture depicting magical runic symbols. When used as a weapon, a staff of power is a +2 greater striking staff." };
            yield return new TextBlock { Id = Guid.Parse("a6fa75b3-8fc3-4932-89fe-8b674917d80d"), Type = TextBlockType.Text, Text = "Voluntarily destroying a staff of power unleashes an incredible blast of energy. When wielding the staff, you can Interact to break it. This releases a 30-foot-burst magical explosion centered on the staff. This deals 2d8 force damage per charge remaining in the staff (DC 40 basic Reflex save). You automatically critically fail your save. A creature reduced to 0 Hit Points by this damage dies instantly; this is a death effect." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("8cf2dfea-4a24-42e9-8f92-6be9ac797bf1"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("9d48c25b-89dd-44bc-82d3-44df6be0f993"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("8aa06e14-2a1e-4783-832e-9d5d75d95806"),
                Price = 1000000,
                ItemLevel = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("cf264f54-c1b4-4152-8241-87c12e592d49"), Level = 1, SpellId = Spells.Instances.RayOfEnfeeblement.ID},
                    new StaveSpell { Id = Guid.Parse("e16c2750-2cab-4676-8338-cbf3a42a518c"), Level = 2, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("aaaa20b7-0792-4840-a42f-7570e774df8f"), Level = 3, SpellId = Spells.Instances.Levitate.ID},
                    new StaveSpell { Id = Guid.Parse("b6a6c666-7a11-4b07-b619-07c37f5a0eac"), Level = 4, SpellId = Spells.Instances.GlobeOfInvulnerability.ID},
                    new StaveSpell { Id = Guid.Parse("99847fc9-2b49-478c-b628-f834e42e49af"), Level = 4, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("3cebb1d5-bbf0-4fd2-9a86-490364baa599"), Level = 5, SpellId = Spells.Instances.MagicMissile.ID},
                    new StaveSpell { Id = Guid.Parse("4cdf3c89-f5d8-4e90-99bc-b73494a5bd28"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                    new StaveSpell { Id = Guid.Parse("6051bc68-b6f6-4083-8257-dd144e5598e1"), Level = 7, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse("9ff073f8-7b83-4621-861b-11cc9c25d6be"), Level = 7, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("75c8631f-4b82-4be4-a0cc-980ad3d6bb09"), Level = 7, SpellId = Spells.Instances.LightningBolt.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14672b72-6cb9-4c47-9639-230769b67059"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
