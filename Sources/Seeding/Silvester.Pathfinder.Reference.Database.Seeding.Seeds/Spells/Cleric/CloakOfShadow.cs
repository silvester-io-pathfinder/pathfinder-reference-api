using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CloakOfShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("8726f5f3-20ee-4612-87e9-d17e867962b3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cloak of Shadow",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                DomainId = Domains.Instances.Darkness.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d6cfb4d-d866-410a-a470-2dfc1e883b3c"), Type = TextBlockType.Text, Text = "You drape the target in a mantle of swirling shadows that make it harder to see. The cloak reduces bright light within a 20-foot emanation to dim light. This is a form of magical darkness and can therefore overcome non-magical light or attempt to counteract magical light as described on page 458 of the Core Rulebook." };
            yield return new TextBlock { Id = Guid.Parse("a1641e3d-6ed9-46df-b4fe-a44e62f2f3ea"), Type = TextBlockType.Text, Text = "The target can use concealed condition gained from the shadows to Hide, though observant creatures can still follow the moving aura of shadow, making it difficult for the target to become completely undetected. The target can use an Interact action to remove the cloak and leave it behind as a decoy, where it remains, reducing light for the rest of the spell's duration. If anyone picks up the cloak after it's been removed by the original target, the cloak evaporates and the spell ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d48da282-4ce3-4a98-abc3-bd1053044dc7"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("30140f1d-1006-4c66-b2cf-5c9653f1b35f"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("014737ee-99fc-4896-bb0d-9b0850d8387b"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("c9efa84c-af1a-4455-a727-9c36d4e765f4"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("dfbdd55e-1890-4695-a0d9-12092733a998"), Traits.Instances.Shadow.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbd8aa33-6c3f-4b04-a33a-d93214413acf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
