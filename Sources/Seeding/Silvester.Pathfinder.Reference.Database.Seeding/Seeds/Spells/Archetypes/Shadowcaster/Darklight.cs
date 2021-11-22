using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Darklight : Template
    {
        public static readonly Guid ID = Guid.Parse("31d9c2a7-cdc4-4844-8bed-7657052b086b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Darklight",
                Level = 7,
                Range = "120 feet.",
                Area = "20-foot burst.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d279497-664f-446f-a5b8-7156e4b6a017"), Type = TextBlockType.Text, Text = "Shadows pour forth from your eyes, creating a field of darkness that prevents light from emanating within the area. Light doesn�t enter the area; any non-magical light sources, such as a torches or lanterns, don�t emanate any light while inside the area, even if their light radius would extend beyond the darkness. The spell similarly suppresses magical light of the spell�s level or lower." };
            yield return new TextBlock { Id = Guid.Parse("d368c4b0-2093-43c5-9ab0-7cfd47026ff6"), Type = TextBlockType.Text, Text = "Light can�t pass through, so creatures in the area can�t see outside. Even creatures with darkvision (but not greater darkvision) can barely see through the darkness; any creatures seen through the darkness are concealed to them. Creatures with greater darkvision can see through the darkness normally." };
            yield return new TextBlock { Id = Guid.Parse("bdb3c106-c902-440c-9acf-e513663827b7"), Type = TextBlockType.Text, Text = "Creatures who move into the field or start their turn within the field have some of the life and light sucked out of them, taking 2d6 bludgeoning damage and 2d6 negative damage, with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("19f353c7-abbb-43bc-899d-e73cb1b9cd79"), Type = TextBlockType.Text, Text = "When you cast this spell, choose up to four allies in the area to spare from darklight�s effects. Until the spell ends, they�re immune to damage from darklight spells and can see through darklight (but not other darkness) as though they had greater darkvision." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e9fdab1d-51f3-417e-ba55-a5d541b342cb"),
                Level = "10th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8c11454f-b4ef-4bcd-b0e3-4a0c75548e7b"), Type = TextBlockType.Text, Text = "The bludgeoning and negative damage both increase to 3d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Darkness.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7884b1d4-906e-4c77-af53-79c232ed5b8e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 227
            };
        }
    }
}