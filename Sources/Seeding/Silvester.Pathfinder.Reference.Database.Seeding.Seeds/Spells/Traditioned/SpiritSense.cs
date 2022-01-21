using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritSense : Template
    {
        public static readonly Guid ID = Guid.Parse("3f22d282-205c-4f1d-9a11-464c7b7f503d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Sense",
                Level = 4,
                Area = "30-foot emanation.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
             yield return new TextBlock { Id = Guid.Parse("bba81d76-2d1a-48f9-9c23-b6b113749f13"), Type = TextBlockType.Text, Text = "You open your mind to the metaphysical, enabling you to sense nearby spirits. Even if you aren't Searching, you get a check to find haunts and spirits in the area. You gain a +1 status bonus to the following checks regarding haunts or spirits: Perception checks to Seek, attempts to Recall Knowledge, skill checks to determine the reason for their existence, and skill checks to disable a haunt. You also gain a +1 status bonus to AC and saving throws against haunts and spirits." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2d07be7d-39ff-48ce-a31e-a936b6b51663"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("316bd87a-2bd4-47be-bb5e-95a1c0c312eb"), Type = TextBlockType.Text, Text = "The spell's duration lasts until the next time you make your daily preparations." }
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
            builder.Add(Guid.Parse("c53cf36c-c0b9-46eb-837a-f96ce6dc5cff"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("35737bbb-19f9-49ae-85d8-f897debaff78"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("3828ca9e-60ce-421c-89eb-82aa4cdece64"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31e96fc2-eac8-475f-a91d-843c496ba9d7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 225
            };
        }
    }
}
