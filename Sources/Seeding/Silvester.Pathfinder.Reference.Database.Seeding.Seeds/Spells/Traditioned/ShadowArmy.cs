using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowArmy : Template
    {
        public static readonly Guid ID = Guid.Parse("853b3cf2-a121-4529-b5a3-a16576e95307");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Army",
                Level = 10,
                Range = "500 feet.",
                Duration = "1 minute.",
                Area = "50-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de21edb4-080e-473c-84f4-914cd964bd04"), Type = TextBlockType.Text, Text = "You create dozens of semi-real copies of yourself that swarm across the battlefield and fight your enemies. You are virtually indistinguishable from your clones, allowing you to Hide and Sneak among them. An enemy that�s in the area when the spell is cast or that ends its turn in the area takes 3d10 mental damage and 3d10 bludgeoning damage, and is possibly inflicted with a condition, depending on the result of its Will save. When you Cast the Spell, you choose a condition your shadows impose on a failed save: clumsy 2, enfeebled 2, flat-footed, or slowed 1." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c9feaaf5-480b-4259-a043-3f885c0af226"),
                CriticalSuccess = "The creature takes no damage. For the duration of the spell, the creature gets a result one step better than it rolled on further saves against the spell, and can distinguish you from your clones without difficulty.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage, and gains the chosen condition.",
                CriticalFailure = "The creature takes double damage, and gains the chosen condition."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("bc80a3ed-3e58-4ea8-9ddb-db7160f70064"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("2ee6e2f3-14f8-43c2-834e-af78c600e956"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("6a8c18d1-c974-4333-a6bf-9427de79429c"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("921cd049-2ee5-44d5-ae49-386973bce02d"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("56a3589f-86f2-44e3-8b24-835d3ca494f9"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f6f7aba-e7bf-4323-99b8-2f1c2ceb651c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 128
            };
        }
    }
}
