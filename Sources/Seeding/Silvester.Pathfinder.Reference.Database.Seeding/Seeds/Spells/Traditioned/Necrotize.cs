using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Necrotize : Template
    {
        public static readonly Guid ID = Guid.Parse("a66904ba-82ab-4867-9ecb-c05f751a8f5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Necrotize",
                Level = 6,
                Range = "60 feet.",
                Duration = "Varies.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("daaec942-c83f-4408-9ece-c7df9a1aeaf5"), Type = TextBlockType.Text, Text = "You necrotize part of a creature�s body, harming it and debilitating it as its body putrefies, mimicking the natural process of decay. The target takes 12d6 negative damage and one of the following debilitations; roll 1d4 to randomly determine which. The effects depend on its Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("b24a9fbc-565b-4217-a707-6fc9e91f9144"), Type = TextBlockType.Enumeration, Text = "1. Bones The target�s bones necrotize and become spongy and weak, giving it weakness 3 to bludgeoning damage." };
            yield return new TextBlock { Id = Guid.Parse("be1106dc-9f2f-4d60-be23-7d38afae5d75"), Type = TextBlockType.Enumeration, Text = "2. Joints The target�s joints necrotize, making its movements ungainly and clumsy. It becomes clumsy 1." };
            yield return new TextBlock { Id = Guid.Parse("4eea87ae-10a4-4fe4-8296-46608d4760a6"), Type = TextBlockType.Enumeration, Text = "3. Legs The target�s legs necrotize, as well as any other limbs associated with forms of movement, making it harder for the creature to move. The target takes a �10-foot status penalty to its Speeds." };
            yield return new TextBlock { Id = Guid.Parse("4e0d18c1-a287-4064-9a1f-23b0377f555f"), Type = TextBlockType.Enumeration, Text = "4. Muscles The target�s muscles necrotize, rotting away. The target becomes enfeebled 1." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("508b1e01-313c-430e-a83d-0adb0e6c3f2c"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c0ec6646-301c-454b-8802-c8736afdad01"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2130d8a3-9793-457c-8bef-72451d4b28d4"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half damage and the debilitation lasts until the end of your next turn.",
                Failure = "The target takes full damage and the debilitation lasts for 1 minute.",
                CriticalFailure = "The target takes double damage, and you can pick a second debilitation to apply, in addition to the one you rolled randomly. Both debilitations last for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a2d0bae-5649-425a-96a9-d4b8111c5912"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 118
            };
        }
    }
}
