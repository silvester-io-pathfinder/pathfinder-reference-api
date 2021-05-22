using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WishTwistedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("b7240ad4-33a6-4720-848e-ef942b1139d7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wish-Twisted Form",
                Level = 5,
                Range = "60 feet.",
                Targets = "1 creature.",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a0a168d-340d-4b53-8866-fe2a98c129b2"), Type = TextBlockType.Text, Text = "You focus your magic upon an enemy, wishing for their defenses to fail and turning their strengths into weaknesses. The target must attempt one Will saving throw for all of the following effects." };
            yield return new TextBlock { Id = Guid.Parse("c16db883-a368-457e-9a5d-f70fb4067dc0"), Type = TextBlockType.Enumeration, Text = "The target gains weakness 5 to one energy type of your choice." };
            yield return new TextBlock { Id = Guid.Parse("5dad7b84-b24e-4643-9a40-ce363fb85665"), Type = TextBlockType.Enumeration, Text = "The target’s resistances are reduced by 5." };
            yield return new TextBlock { Id = Guid.Parse("f30038b8-e268-4879-ae15-57a09a3968dd"), Type = TextBlockType.Enumeration, Text = "The target takes a –10-foot status penalty to all its Speeds." };
            yield return new TextBlock { Id = Guid.Parse("168f9784-bdee-49c2-8215-a8b8b58965ed"), Type = TextBlockType.Enumeration, Text = "The target takes a –1 status penalty to its saving throws." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("be8bec94-0a87-49c9-9c59-7db3770799dd"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7a2138e3-5fc8-4779-8515-5a86d8857049"), Type = TextBlockType.Text, Text = "Increase the weakness and the reduction to resistances by 1." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("574e5ece-6cd8-4d6e-9fdd-4a410f3feccc"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes the penalties for 1 round.",
                Failure = "The target takes the penalties for 1 minute.",
                CriticalFailure = "As failure, and the target takes a –1 status penalty to AC for the duration."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec758cd5-0675-46b0-ab36-51d68e4412b7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
