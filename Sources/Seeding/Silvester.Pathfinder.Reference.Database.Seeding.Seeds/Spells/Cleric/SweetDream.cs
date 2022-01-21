using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SweetDream : Template
    {
        public static readonly Guid ID = Guid.Parse("90f111cc-f4a8-4c26-bfb1-a6ac79d98539");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sweet Dream",
                Level = 1,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "1 willing creature.",
                DomainId = Domains.Instances.Dreams.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5792b854-3225-4742-be9a-ecc77ef3d197"), Type = TextBlockType.Text, Text = "With soothing song or tales, you lull the target into an enchanting dream. When you cast the spell, the target falls unconscious if it wasn't already. While unconscious, it experiences a dream of your choice. If it sleeps for at least 1 minute, it gains the benefit of the dream for the remainder of the spell's duration." };
            yield return new TextBlock { Id = Guid.Parse("cbdc06b0-4b9c-4944-9202-5280e95021a8"), Type = TextBlockType.Enumeration, Text = "Dream of Insight - +1 status bonus to Intelligence-based skill checks." };
            yield return new TextBlock { Id = Guid.Parse("021979d7-33b0-462c-b375-28c0ec7dea46"), Type = TextBlockType.Enumeration, Text = "Dream of Glamour - +1 status bonus to Charisma-based skill checks." };
            yield return new TextBlock { Id = Guid.Parse("f521a944-b1d4-4353-974d-ca5a0fd9b7f3"), Type = TextBlockType.Enumeration, Text = "Dream of Voyaging - +5-foot status bonus to Speed." };
            yield return new TextBlock { Id = Guid.Parse("1a8ce36f-d599-4b3c-8190-f01078a4173e"), Type = TextBlockType.Text, Text = "If you Cast this Spell again, the effects of any previous sweet dream you cast end." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1945f4f1-bfe1-4674-aeb3-021976701d70"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e0734289-8eb0-4107-b4c8-c8f1abd33f51"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("7279429c-3702-4775-bd15-6df299a72f48"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("aad6c0f7-74b4-404f-964d-d8959814d010"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("da277210-93c2-445e-b88b-01b688408a76"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("5a56ce4f-bc6f-490b-86ad-ef5f23effa29"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("82e0b010-8055-4c34-a823-338e10e8f3e1"), Traits.Instances.Sleep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5fab4ae-e1de-4384-b5f4-73f6ebe3d6c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
