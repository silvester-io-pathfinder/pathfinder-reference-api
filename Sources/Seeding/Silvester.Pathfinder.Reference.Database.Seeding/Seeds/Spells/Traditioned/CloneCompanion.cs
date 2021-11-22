using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CloneCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("eb54fccc-d9e9-45c3-b38f-1c953b75f659");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clone Companion",
                Level = 8,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                Targets = "Your companion.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d2b578e-f46d-461b-b0ba-14fd520ee0a7"), Type = TextBlockType.Text, Text = "You create a duplicate of your companion, and the duplicate fights alongside its twin, mirroring the original�s actions. The duplicate appears adjacent to your companion and has the same statistics." };
            yield return new TextBlock { Id = Guid.Parse("624f371a-4633-4820-abd5-e786f02d97fe"), Type = TextBlockType.Text, Text = "Each time you Command your companion, both your companion and its duplicate gain 2 actions. The duplicate always acts immediately after your companion and must use identical actions to the ones your companion used, in exactly the same order. However, it can use the actions differently, such as Striding to a different position or selecting a different target for a Strike. If the duplicate is unable to mimic an action, it performs the action without result and the action is wasted. The duplicate can�t use any actions that can be used only a limited number of times per day." };
            yield return new TextBlock { Id = Guid.Parse("ccf2e648-c8e1-4ba1-ab6b-57ecd631614f"), Type = TextBlockType.Text, Text = "The duplicate isn�t truly alive and can�t be healed in any way. If the duplicate ever reaches 0 Hit Points, it is instantly destroyed and clone companion immediately ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f8496d2-da01-44e5-9b5c-de59191f36f3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 96
            };
        }
    }
}
