using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CurseOfLostTime : Template
    {
        public static readonly Guid ID = Guid.Parse("ddb80bc6-bafe-4cd7-8005-b490eccf9b82");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Curse of Lost Time",
                Level = 3,
                Range = "Touch.",
                Duration = "Varies.",
                Targets = "1 large or smaller object, construct or living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9eb49bc4-f8a7-431e-8380-39d6e5094a13"), Type = TextBlockType.Text, Text = "You mimic the process of aging or erosion on the target. The effect depends on whether the target is an object, a construct, or a living creature. Artifacts and objects and constructs made of precious materials, as determined by the GM, are immune." };
            yield return new TextBlock { Id = Guid.Parse("1a491cca-93d5-4e67-bda8-8854bb0dce10"), Type = TextBlockType.Enumeration, Text = "Object - If the object is attended, its bearer can attempt a Fortitude save. If the bearer fails or the object is unattended, the object immediately takes 4d6 damage (applying Hardness normally) and the item is cursed with an unlimited duration. Until the curse ends, the item becomes shoddy and can’t be Repaired, and the curse attempts to counteract any spell that would restore the object’s Hit Points. Remove curse can target an item affected by this spell." };
            yield return new TextBlock { Id = Guid.Parse("2ab7703a-7d70-4738-a5cc-e12de56a8e45"), Type = TextBlockType.Enumeration, Text = "Construct - The construct takes 4d6 damage (basic Fortitude save). On a failure, for 1 hour the construct is clumsy 1, is enfeebled 1, and can’t be Repaired, and the curse attempts to counteract any spell that would restore the construct’s Hit Points. On a critical failure, these effects have an unlimited duration." };
            yield return new TextBlock { Id = Guid.Parse("1f32fd20-3a87-4d3a-ab0f-01b42891d1e8"), Type = TextBlockType.Enumeration, Text = "Living - Creature The living creature must attempt a Fortitude save. Ageless creatures are immune." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b4654414-93ce-4533-836c-980fb310ba0b"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3693747b-aa07-411a-be69-3b128ea48ec8"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("66aa3c5c-3343-4b3e-9c38-4456a9c4f3e1"),
                CriticalSuccess = "The living creature is unaffected.",
                Success = "The living creature briefly ages, becoming clumsy 1 and enfeebled 1 for 1 round.",
                Failure = "As success, with a duration of 1 hour.",
                CriticalFailure = "As success, with an unlimited duration."
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Negative.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0a5081e-c18f-4ec7-bd22-cb64718f2c1b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
