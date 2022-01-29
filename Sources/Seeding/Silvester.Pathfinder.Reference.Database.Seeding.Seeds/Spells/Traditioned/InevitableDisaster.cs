using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InevitableDisaster : Template
    {
        public static readonly Guid ID = Guid.Parse("1cefa01a-7a2e-4b69-a204-52d8b1d0d22f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inevitable Disaster",
                Level = 5,
                Range = "60 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f21ff13d-6c48-4095-9074-48bfec346bdc"), Type = TextBlockType.Text, Text = "You briefly glimpse cause and effect, putting into motion a chain of events that will visit doom on your enemy at some point in the future, though you're not quite sure when or how the doom will occur. Some kind of strange accident occurs 1d4 rounds later, dealing 55 damage to the creature, with a basic Fortitude save. This happens regardless of where the target is located at the time, even if it travels to another plane. The GM should roll to determine when the damage occurs secretly and determine the form of the accident as well as the type of damage it deals; generally, the accident should be one that deals physical damage of some type (for instance, a tree branch might fall on the foe and deal bludgeoning damage, or a window might break and fling sharp slashing glass at them), though other damage types might be appropriate in more unusual environments." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e81c8756-d0cd-4f31-a534-5a1271c620be"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("bd339ade-1539-4b54-a9a6-c96a7c3f7072"), Type = TextBlockType.Text, Text = "The damage increases by 10." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4b433282-d1c8-4295-ba70-deb76eab0714"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("32efde7d-f844-4da2-af5d-b57491930c46"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("65c7c32d-5af9-4c4c-98eb-e7467c5be612"), Traits.Instances.Prediction.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc642619-2eea-4ee5-8a6f-d3286e5af059"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 111
            };
        }
    }
}
