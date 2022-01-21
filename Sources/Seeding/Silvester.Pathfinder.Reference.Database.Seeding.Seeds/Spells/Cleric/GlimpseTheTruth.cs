using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GlimpseTheTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("25ada8e9-89ac-4106-aa58-7dab9d690629");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glimpse The Truth",
                Level = 4,
                Area = "30-foot emanation.",
                Duration = "1 round.",
                DomainId = Domains.Instances.Truth.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23ead71d-4f43-4e24-94ff-8aa5b1ebfdcd"), Type = TextBlockType.Text, Text = "Divine insight lets you see things as they truly are. The GM attempts a secret counteract check against each illusion that is at least partially within the area. Instead of counteracting the illusion, you see through it (for instance, if the check succeeds against an illusory disguise spell, you see the creature's true form but illusory disguise doesn't end)." };
            yield return new TextBlock { Id = Guid.Parse("30bc0221-72ba-414f-9cc1-2c17459da25a"), Type = TextBlockType.Text, Text = "The area moves with you for the duration of the spell, and the GM attempts a secret counteract check each time a new illusion is within the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9a50eed-c43c-4316-ae2e-baa5b82ffd23"),
                Level = "7h",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e8de9d54-66f6-4b73-8afb-537a81c931ab"), Type = TextBlockType.Text, Text = "You can allow everyone to see through illusions you succeed against, not just yourself." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("66c2593c-5a03-4f64-8ea3-ce784c51db8f"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f8653258-48fa-40fb-a50b-0dbfa284c6d0"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("1f6a7999-02e4-44bb-84f2-8f92850e0765"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("90a708f6-8741-409e-86d8-834b9a76e1c5"), Traits.Instances.Revelation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dae5010-69ee-4bd1-88ae-bf2cf17a4a4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
