using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("9ff794c4-74a1-412e-9d44-06d64f1570b1");
        
        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Acid Arrow",
                Targets = "1 creature.",
                Level = 2,
                Range = "120 feet.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab27ff6e-2d8a-4928-a6ea-88b7d0504011"), Type = Utilities.Text.TextBlockType.Text, Text = "You conjure an arrow of acid that keeps corroding the target after it hits. Make a spell attack against the target. On a hit, you deal 3d8 acid damage plus 1d6 persistent acid damage. On a critical hit, double the initial damage, but not the persistent damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("ce2df890-5896-491e-a1f2-18a9808e1682"), 
                Level = "+2",  
                Details =
                {
                    new TextBlock { Id = Guid.Parse("aab0c30f-4a1b-499f-bd9c-8a26f616fb98"), Type = Utilities.Text.TextBlockType.Text, Text = "The initial damage increases by 2d8, and the persistent acid damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d1995f4-dc7c-4f0a-9b07-1d4c4013404a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 316
            };
        }
    }
}
