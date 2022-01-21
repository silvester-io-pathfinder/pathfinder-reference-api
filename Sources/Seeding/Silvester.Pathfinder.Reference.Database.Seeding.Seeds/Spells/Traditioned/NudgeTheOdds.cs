using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NudgeTheOdds : Template
    {
        public static readonly Guid ID = Guid.Parse("5e692e91-5547-462e-aec7-77d367ee5acb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nudge the Odds",
                Level = 1,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("518879ed-ebd0-4c12-95c5-f4370a348e6c"), Type = TextBlockType.Text, Text = "You bestow yourself supernaturally good luck at cards, dice, and other games of chance. You gain a +1 status bonus to Games Lore checks to gamble, and if you roll a critical failure on such a check, you get a failure instead; however, the spell is too short-lived to use for Earn Income checks from gambling." };
            yield return new TextBlock { Id = Guid.Parse("4872f959-ecd6-48a7-ae3b-6b9d92166481"), Type = TextBlockType.Text, Text = "When you�re under the effect of nudge the odds, one facial feature, such as a lock of hair or the iris of an eye, transforms to a distinctive golden color; the GM chooses which feature when you cast the spell. This change resists all magical efforts to conceal it, though it can be hidden or covered by mundane means. A creature noticing the feature can identify the spell using Recall Knowledge. Because it prevents losing big, gamblers consider nudge the odds a repugnant form of cheating. If you�re caught using the spell, you are likely to suffer serious consequences, depending on the nature of the gamblers you cheated." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("68d3d4c6-e2ba-407a-9d7b-aaed80a2f8bc"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8809efd7-4560-4018-985c-f59a74dbbafa"), Type = TextBlockType.Text, Text = "The status bonus increases to +2, and the duration increases to last until the next time you make your daily preparations. If you continue spending your spell slot to keep the duration active, this allows you to apply the effect to a downtime check to Earn Income." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6099b83a-92f9-49ed-9f57-11b365df9792"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("97fbe94a-e541-4733-a41c-e9c583ed3f36"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85e5af72-ca9d-441c-a090-80478f33e10c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 118
            };
        }
    }
}
