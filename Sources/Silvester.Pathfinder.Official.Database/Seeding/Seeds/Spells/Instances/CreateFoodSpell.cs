using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CreateFoodSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("2d0fa5a4-eab0-4eca-85cb-23241e5ef814");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Create Food",
                Level = 2,
                CastTime = TimeSpan.FromHours(1),
                Range = 30,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1648108-d584-408c-a9e0-395e9411b398"), Type = Utilities.Text.TextBlockType.Text, Text = "You create enough food to feed six Medium creatures for a day. This food is bland and unappealing, but it is nourishing. After 1 day, if no one has eaten the food, it decays and becomes inedible. Most Small creatures eat one-quarter as much as a Medium creature (one-sixteenth as much for most Tiny creatures), and most Large creatures eat 10 times as much (100 times as much for Huge creatures and so on)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("923762df-f025-49e3-9f23-b82e97f15e5a"),
                Level = 4, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8dffaa04-8c24-4fa4-b478-2efcc90c1a5b"), Type = Utilities.Text.TextBlockType.Text, Text = "You can feed 12 Medium creatures." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("14353fce-2884-4203-ae5c-2a52cc7c629b"), 
                Level = 6, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dff09106-b5bd-4cfa-b0b3-2d42023285f6"), Type = Utilities.Text.TextBlockType.Text, Text = "You can feed 50 Medium creatures." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("d5f956fa-1486-461c-9ff5-94db3f1f5cdd"), 
                Level = 8,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("186fc125-7b6f-4519-94f4-a2e13d192f61"), Type = Utilities.Text.TextBlockType.Text, Text = "You can feed 200 Medium creatures." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }
    }
}
