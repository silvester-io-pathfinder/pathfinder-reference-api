using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CompetitiveEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("9bf07bd2-5619-4669-aff9-6dee9f939629");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Competitive Edge",
                Level = 4,
                IsDismissable = true,
                Duration = "Sustained up to a minute.",
                DomainId = Domains.Instances.Ambition.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7e64c98-103b-457e-8a7a-97603fa8ccdb"), Type = TextBlockType.Text, Text = "Your competitiveness drives you to prove yourself against the opposition. You gain a +1 status bonus to attack rolls and skill checks. If an enemy within 20 feet critically succeeds at an attack roll or skill check, your status bonus increases to +3 attack rolls or that specific skill check (whichever the foe critically succeeded at) for 1 round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8273eaed-4cdb-4cf1-90fd-f2d5f7b95d1a"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("842ba897-775f-4b5e-9dcf-08c7decfa436"), Type = TextBlockType.Text, Text = "Increase the base bonus to +2 and the increased bonus after an enemy critically succeeds to +4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3f2a31df-6bd7-4173-ba1b-0a78ba07f22d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d919c6ce-ae88-48d5-b1c0-06f75c1668d9"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("caa7bd04-5cf9-4445-ba06-efaf782b2e32"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("6d05ffc9-6d90-432e-93a2-45fcadf08446"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("11284afe-99ec-4421-acc5-3e92d9377ac4"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("779b394a-cd94-4918-8507-27af2ffc0ead"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
