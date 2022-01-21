using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PerniciousPoltergeist : Template
    {
        public static readonly Guid ID = Guid.Parse("f44514c4-bae0-4852-b679-56858ec79b61");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pernicious Poltergeist",
                Level = 4,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "10-foot burst.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("567e5d18-e272-46e2-92f7-735a3f4fe447"), Type = TextBlockType.Text, Text = "You create an echo of a powerful poltergeist, temporarily anchoring it to the area to terrorize and harm any opponents foolish enough to remain in the area. Because the poltergeist is a manifestation and is not truly present, it can�t be attacked or hurt; it remains invisible unless otherwise stated. When you Cast the Spell, and the first time you Sustain it on subsequent rounds, the poltergeist creates your choice of one of the following effects." };
            yield return new TextBlock { Id = Guid.Parse("7bd3d696-3d6f-4f81-a8e8-bd8ced621006"), Type = TextBlockType.Enumeration, Text = "Deathly Assault (negative) - The poltergeist focuses on one creature in the area and flies through that creature�s space, dealing 4d10 negative damage (basic Fortitude save)." };
            yield return new TextBlock { Id = Guid.Parse("960628bc-7e12-414f-a0fc-02d4c76a5133"), Type = TextBlockType.Enumeration, Text = "Frighten (emotion, fear, mental) - The poltergeist becomes visible, appearing as a skeletal, ghostlike humanoid. Creatures in the area must attempt a Will save, becoming frightened 2 on a failure." };
            yield return new TextBlock { Id = Guid.Parse("357ed8c7-9ac4-44cd-9456-614e4408e96d"), Type = TextBlockType.Enumeration, Text = "Telekinetic Storm (force) - The poltergeist hurls debris and quasi-real objects around in the area. All creatures in the area take 4d8 force damage (basic Reflex save)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("26c42529-86e4-4627-85d2-251ebf15b7ee"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3feee820-e7b9-40e9-8ec9-6668ef4ee522"), Type = TextBlockType.Text, Text = "The damage of the deathly assault effect increases by 1d10, and the damage of the telekinetic storm effect increases by 1d8." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("18e1f760-efa1-4bad-8c4d-193e67ae46f6"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b51fb53c-b9a1-4c6a-91c7-0d2679d18b51"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 121
            };
        }
    }
}
