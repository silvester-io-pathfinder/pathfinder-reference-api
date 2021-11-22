using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LoremastersEtude : Template
    {
        public static readonly Guid ID = Guid.Parse("96a33e5e-8662-4342-86f3-c3bebd52b541");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Loremaster's Etude",
                Level = 1,
                Range = "30 feet.",
                Trigger = "You or an ally within range attempts a skill check to Recall Knowledge.",
                Targets = "You or the triggering ally.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("437f0fc5-4c7f-4f18-88de-4c76a9cdecd2"), Type = TextBlockType.Text, Text = "You call upon your muse's deep mysteries, granting the target a greater ability to think and recall information. Roll the triggering Recall Knowledge skill check twice and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba9b72ff-6cd6-4583-9842-a11a44d2ba6e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
