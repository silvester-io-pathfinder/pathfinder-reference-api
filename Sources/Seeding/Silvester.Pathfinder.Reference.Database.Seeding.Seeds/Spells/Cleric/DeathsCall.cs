using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DeathsCall : Template
    {
        public static readonly Guid ID = Guid.Parse("10a5b873-c7bf-48cf-96cc-3afe69d7664b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Death's Call",
                Level = 1,
                Trigger = "A living creature within 20 feet of you dies, or an undead creature within 20 feet of you is destroyed.",
                Duration = "1 minute.",
                DomainId = Domains.Instances.Death.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07eddc65-7da8-45f3-b294-72069a9abbea"), Type = TextBlockType.Text, Text = "Seeing another pass from this world to the next invigorates you. You gain temporary Hit Points equal to the triggering creature's level plus your spellcasting ability modifier. If the triggering creature was undead, double the number of temporary Hit Points you gain . These last for the duration of the spell, and the spell ends if all the temporary Hit Points are depleted earlier." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("da18a392-fd75-4cee-b420-9335da5f4f31"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a23f7112-db9a-4c70-9273-c1d5fe4075d1"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("4ddcf948-058e-4a7c-bb2d-bb4e5bfb9b52"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20af7f92-abb5-4d2a-b311-4fbc2bb29182"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
