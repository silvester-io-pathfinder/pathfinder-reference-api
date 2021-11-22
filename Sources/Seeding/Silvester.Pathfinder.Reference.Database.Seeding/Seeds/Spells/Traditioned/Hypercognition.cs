using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Hypercognition : Template
    {
        public static readonly Guid ID = Guid.Parse("d0d30141-0e90-4703-bbdc-4ceb661e6689");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hypercognition",
                Level = 3,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d027236-8796-4bc2-aef2-d251d4076bbc"), Type = TextBlockType.Text, Text = "You rapidly catalog and collate information relevant to your current situation. You can instantly use up to 6 Recall Knowledge actions as part of Casting this Spell. For these actions, you can't use any special abilities, reactions, or free actions that trigger when you Recall Knowledge." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19463e2e-a84b-4334-b102-78d38c30f9af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
