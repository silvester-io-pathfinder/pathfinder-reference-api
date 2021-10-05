using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VibrantThorns : Template
    {
        public static readonly Guid ID = Guid.Parse("9ff44d68-af4d-46db-8ecb-9196c27dcc89");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vibrant Thorns",
                Level = 1,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Nature.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5571deb3-1589-43ce-81cc-a78a94183440"), Type = TextBlockType.Text, Text = "Your body sprouts a coat of brambly thorns that harm those that strike you and thrive on life magic. Adjacent creatures that hit you with a melee attack, as well as creatures that hit you with unarmed attacks, take 1 piercing damage each time they do. Anytime you cast a positive spell, the damage from your thorns increases to 1d6 until the start of your next turn." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("203dd9b9-90a1-415d-a8ed-4409ca90d1d9"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("eb5d9611-92e0-48cb-882a-d82cc070609e"), Type = TextBlockType.Text, Text = "The damage increases by 1, or 1d6 after you cast a positive spell." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da139c85-e326-4515-a0e3-23ea9f116b21"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
