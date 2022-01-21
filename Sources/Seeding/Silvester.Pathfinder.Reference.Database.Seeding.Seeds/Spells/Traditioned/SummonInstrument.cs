using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("4804b806-7a8f-42aa-9ba7-81e2aa62ac4f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Instrument",
                Level = 1,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c9cea57-71af-4d7c-a642-b3fa8bcce08a"), Type = TextBlockType.Text, Text = "You materialize a handheld musical instrument in your grasp. The instrument is typical for its type, but it plays only for you. The instrument vanishes when the spell ends. If you cast summon instrument again, any instrument you previously summoned disappears." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f33a66b6-0b0e-4c84-9045-32aa37ece3d6"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("61fb54b9-76ab-4d02-9ed3-9bb9e0d23146"), Type = TextBlockType.Text, Text = "The instrument is instead a virtuoso handheld instrument." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d340f5d1-a84e-4bea-9c32-a5b94ad1de44"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("5184edfe-9b5d-4adf-ae48-731171833304"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4433af5c-0297-46ac-927f-af86730000fc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
