using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CatchYourName : Template
    {
        public static readonly Guid ID = Guid.Parse("03c94ae8-9534-43a0-8b07-33290142f305");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Catch Your Name",
                Level = 6,
                Trigger = "A creature on your plane speaks your private or true name.", 
                Requirements = "You know your own true name.", 
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ded724d-e906-4147-b496-cf9445933f77"), Type = TextBlockType.Text, Text = "You learn a private name (but not the true name) of the creature who spoke your name, as well as their precise location, unless they succeed at a Will save to negate the effect. You are aware any time the trigger conditions are met as long as you have the spell prepared or in your repertoire. There is no way to distinguish one trigger of this spell from another without actually casting the spell. This can become a nuisance if you are so famous that your name is regularly on others� lips." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("76cd9130-6f37-452a-8e93-af0826508c07"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("7f175692-ae50-4c0a-95fa-ca3071396abb"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f719bf20-f9a7-439c-8f70-603238c3658a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 247
            };
        }
    }
}