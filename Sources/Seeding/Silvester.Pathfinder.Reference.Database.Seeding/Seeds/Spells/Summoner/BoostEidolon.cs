using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BoostEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("84b562f2-78ed-4c94-8a2e-4dbd9a5168f9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Boost Eidolon",
                Level = 1,
                Range = "100 feet.",
                Targets = "Your eidolon.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Summoner.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e05a862-c47f-4d56-af13-e30febd7a24a"), Type = TextBlockType.Text, Text = "You focus deeply on the link between you and your eidolon and boost the power of your eidolon's attacks. Your eidolon gains a +2 status bonus to damage rolls with its unarmed attacks. If your eidolon's Strikes deal more than one weapon damage die, the status bonus increases to 2 per weapon damage die, to a maximum of +8 with four weapon damage dice." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Summoner.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec16f19e-9fb6-40a7-8cf3-932b208e64e5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
