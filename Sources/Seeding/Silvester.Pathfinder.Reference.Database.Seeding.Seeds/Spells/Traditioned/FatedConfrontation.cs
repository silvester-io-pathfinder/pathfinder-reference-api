using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FatedConfrontation : Template
    {
        public static readonly Guid ID = Guid.Parse("21f18000-6c85-4588-8f5e-d06f346dbfd1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fated Confrontation",
                Level = 10,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "1 willing ally and 1 enemy.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("082428ff-7e58-45cf-8a63-537e2b46b442"), Type = TextBlockType.Text, Text = "You weave the threads of fate to lead two foes into a climactic battle. The targets of this spell are the fated opponents: one of the targets of this spell must be you or a willing ally, and the other must be an enemy." };
            yield return new TextBlock { Id = Guid.Parse("cf730f05-462c-42ba-a88f-fcaea1e67c62"), Type = TextBlockType.Text, Text = "When you Cast the Spell, the ally you targeted (or you, if you targeted yourself) may teleport to any unoccupied space of their choice within 30 feet of its fated opponent. This is a teleportation effect." };
            yield return new TextBlock { Id = Guid.Parse("97cf4447-1768-4f55-a511-aeeefbc77218"), Type = TextBlockType.Text, Text = "You isolate the two targets for 1 round. During this time, fate refuses to allow either fated opponent to be affected by attacks or effects from a third party; a fated opponent could be affected by the other's meteor swarm or its own heal spell, but it would be entirely immune to a spell or Strike from a creature outside of the spells effects, as well including damage from a hazard or the environment. This doesn't apply to anything that was affecting the targets before you cast fated confrontation (such as a spell with a duration or persistent damage the creature had before it was affected by fated confrontation)." };
            yield return new TextBlock { Id = Guid.Parse("29946ed5-ca1a-403a-b53c-bb324767160a"), Type = TextBlockType.Text, Text = "For the duration of the spell, either fated opponent can manipulate fate once on each of its turns. This allows it to either roll twice and take the higher result on an attack roll or skill check it makes against its fated opponent (a fortune effect), or force the fated opponent to roll twice on a saving throw against one of its abilities and take the lower result (a misfortune effect)." };
            yield return new TextBlock { Id = Guid.Parse("21597d80-4918-438f-a22e-e40ac59dce1f"), Type = TextBlockType.Text, Text = "This spell ends if either target becomes unable to act, or if they both agree to cease hostilities." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
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
            builder.Add(Guid.Parse("923e5b9f-fe24-4d45-bbf8-e66e4b35eb55"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1ea3c61-1bf6-4ee3-b5c0-0a859b0da847"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 105
            };
        }
    }
}
