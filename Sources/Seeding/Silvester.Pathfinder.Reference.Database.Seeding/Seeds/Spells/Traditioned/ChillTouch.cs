using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChillTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("4ab38c95-8b8a-4f7c-b260-1b842a91ace3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chill Touch",
                Level = 1,
                Range = "Touch.",
                Targets = "1 living or undead creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8375c268-b418-4cff-9dde-0d0e11f57a48"), Type = Utilities.Text.TextBlockType.Text, Text = "Siphoning negative energy into yourself, your hand radiates a pale darkness. Your touch weakens the living and disorients undead, possibly even causing them to flee. The effect depends on whether the target is living or undead." };
            yield return new TextBlock { Id = Guid.Parse("a08010bb-278e-457b-8a83-9bd955303460"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Living Creature: The spell deals negative damage equal to 1d4 plus your spellcasting modifier. The target attempts a basic Fortitude save, but is also enfeebled 1 for 1 round on a critical failure." };
            yield return new TextBlock { Id = Guid.Parse("5a911837-34c2-47c2-b348-125d22fea173"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Undead Creature: The target is flat-footed for 1 round on a failed Fortitude save. On a critical failure, the target is also fleeing for 1 round unless it succeeds at a Will save. Heightened (+1)" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4c4341f2-16d9-4a55-b504-418231e4b9fe"), 
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e508583c-8cdb-4634-91ff-dd70e33fd411"), Type = Utilities.Text.TextBlockType.Text, Text = "The negative damage to living creatures increases by 1d4." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a4b969f-91b2-4edd-9dfc-968822a87e75"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 323
            };
        }
    }
}
