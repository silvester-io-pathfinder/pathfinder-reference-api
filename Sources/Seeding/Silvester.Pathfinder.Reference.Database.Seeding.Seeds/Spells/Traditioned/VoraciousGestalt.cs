using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VoraciousGestalt : Template
    {
        public static readonly Guid ID = Guid.Parse("aa08b8bc-0956-4301-98fc-f110e4a43223");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Voracious Gestalt",
                Level = 9,
                Duration = "Sustained up to 1 minute.",
                Area = "30-foot emanation.",
                IsDismissable = true,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a580fda-99a9-4ebc-bd0d-13551e378f5c"), Type = TextBlockType.Text, Text = "You create a powerful spirit entity that grows and builds strength by consuming the spirits of foes you both slay. When you Cast the Spell, the gestalt deals 14d6 negative damage to all living creatures of your choice in the area, with a basic Fortitude save. Creatures you choose that end their turns in the area take 6d6 damage, with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("6b3fb908-cc48-4311-b395-9c263dbabef8"), Type = TextBlockType.Text, Text = "At the end of each of your turns, if you killed a living creature during that turn or if the gestalt's damage killed a creature since the end of your prior turn, you add the slain creature's soul to the gestalt. The emanation's radius increases by 20 feet and the damage dealt by the aura increases by 1d6. (Note that this increase only happens once, even if you killed multiple living creatures that turn.) As normal for determining threat level, the GM determines if a creature is of significant enough threat to empower the gestalt; in general, a creature several levels below you rarely poses a significant threat." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b138514c-87c3-4c3c-ae40-3eb15ef1adaf"),
                Level = "10th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ae5b0bc3-6056-413e-b24e-a080ba6354bf"), Type = TextBlockType.Text, Text = "The initial damage increases to 16d6 and the aura's damage starts at 7d6." }
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
            builder.Add(Guid.Parse("6dfa5263-7f2e-4e70-aa21-d029144b367b"), Traits.Instances.Aura.ID);
            builder.Add(Guid.Parse("7b3b79e2-8935-459a-a9c5-73956abae281"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("020bcf43-7c2d-4f53-b6e1-d31b98579c41"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("a4fe7947-4314-47b0-a1df-4730cf190777"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2eea841-0bed-45a4-b7d6-ea2c65274ac3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 139
            };
        }
    }
}
