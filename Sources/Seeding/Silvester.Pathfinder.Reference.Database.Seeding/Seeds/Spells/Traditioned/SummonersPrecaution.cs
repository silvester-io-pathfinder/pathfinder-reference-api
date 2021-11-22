using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonersPrecaution : Template
    {
        public static readonly Guid ID = Guid.Parse("f7451e76-3218-4b1d-8c96-4c43e2bd4ded");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summoner's Precaution",
                Level = 2,
                Requirements = "You have an eidolon.",
                Duration = "Until your next daily preparations.",
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a5e1cc5-a903-4ae6-bdf7-8c6c466f157e"), Type = TextBlockType.Text, Text = "You create a buffer in the link between yourself and your eidolon in order to prevent you from falling alongside your bonded ally. You gain the following reaction; after using it, the spell ends." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("a50b9362-213d-4c82-9349-891ae8b0260b"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Trigger = "Your eidolon takes damage that would bring you to 0 Hit Points and comes from an effect other than a death effect.",
                Name = "Sever Conduit",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("04ef38d2-5144-4c7b-ae0b-f12ec488d8a6"), Type = TextBlockType.Text, Text = "You quickly shut the buffer in your link with your eidolon, causing your bonded ally to wink out of existence before you can be laid low. Your eidolon unmanifests, and you can�t Manifest your Eidolon for 1 minute. In exchange, you don�t take the triggering damage, though your eidolon still suffers any other adverse effects that accompanied the damage." }
                }
            };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efd67c3e-b355-476c-83ec-09cc280fe0e2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
