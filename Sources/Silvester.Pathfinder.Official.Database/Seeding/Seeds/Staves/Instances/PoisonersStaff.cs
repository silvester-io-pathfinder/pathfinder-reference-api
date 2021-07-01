using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class PoisonersStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("e9e7ca52-dbd8-438f-929f-366dc6667216");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Poisoner's Staff",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1a6f52bb-1aec-4fb2-8444-b7b84ca5776d"), Type = TextBlockType.Text, Text = "This gnarled staff is covered with thorns and coated with a glistening lacquer that acts as a minor irritant. While holding the staff, you aren't affected by its coating or thorns, and you reduce the DC of your flat checks to overcome persistent poison damage." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("445623ed-5c1d-466f-b7d0-4405b376b1f6"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("1a0de2bd-c73d-4e7b-a746-a173c0533aaf"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }
        
        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("08c086bc-5e66-4625-b599-c15fba313c6e"),
                Price = 9000,
                ItemLevel = 4,
                Addendum = "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 13.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("6ce967af-1ad7-4d94-bb56-284d48cf6c0d"), SpellId = Spells.Instances.Guidance.ID},
                    new StaveSpell { Id = Guid.Parse("e643c8fe-ed1a-4fed-86ac-c49f56b881a9"), Level = 1, SpellId = Spells.Instances.DetectPoison.ID},
                    new StaveSpell { Id = Guid.Parse("755230b3-2199-4a12-89f4-a354d1856f17"), Level = 1, SpellId = Spells.Instances.SpiderSting.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("a76fbb8c-4863-4408-9246-ea95d9abb287"),
                Price = 45000,
                ItemLevel = 8,
                Addendum = "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 10.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("4724fd20-4831-440e-a50f-96bca28f5c6d"), Level = 2, SpellId = Spells.Instances.EnhanceVictuals.ID},
                    new StaveSpell { Id = Guid.Parse("fc7fe6c0-bcc3-4f3c-9479-6d282f9cf5e7"), Level = 2, SpellId = Spells.Instances.ImpSting.ID},
                    new StaveSpell { Id = Guid.Parse("66460ee2-a85a-4daa-a2db-c752dcf41499"), Level = 3, SpellId = Spells.Instances.NeutralizePoison.ID},
                    new StaveSpell { Id = Guid.Parse("a7a7b5e4-2a52-4957-bea9-23ab1e78af09"), Level = 3, SpellId = Spells.Instances.StinkingCloud.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("d1fcf415-ca61-40e9-ab27-b6662d453142"),
                Price = 400000,
                ItemLevel = 14,
                Addendum = "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 5.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3195dae1-145d-473f-8e14-8f2c1752be68"), Level = 4, SpellId = Spells.Instances.SwarmingWaspStings.ID},
                    new StaveSpell { Id = Guid.Parse("59120307-5ae3-4e21-85ec-c46f5c836311"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("df261ced-c571-4389-af60-6f8ce831c622"), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8ac2256-373c-4c84-8b3e-7456db5d2144"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
