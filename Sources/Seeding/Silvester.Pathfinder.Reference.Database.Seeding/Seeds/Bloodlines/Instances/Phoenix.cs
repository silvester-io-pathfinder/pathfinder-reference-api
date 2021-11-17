using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Phoenix : Template
    {
        public static readonly Guid ID = Guid.Parse("b2147ec3-fae2-43e6-bbd8-4b60d31f4680");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Phoenix",
                BloodMagic = "The primal fire of life and death flows through you or one target. Choose to have either you or a target of the spell gain temporary Hit Points equal to the spell's level for 1 round, or to have a target of the spell take fire damage equal to the spell's level (if the spell already deals initial fire damage, combine this with the spell's initial damage before determining weaknesses and resistances).",
                RarityId = Rarities.Instances.Uncommon.ID,
                InitialBloodlineSpellId = Spells.Instances.RejuvenatingFlames.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ShroudOfFlame.ID,
                GreaterBloodlineSpellId = Spells.Instances.CleansingFlames.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7a509f0e-dffa-4469-b602-1c14a0df22d8"), Type = TextBlockType.Text, Text = "You have been blessed by a phoenix, perhaps via some magical interaction with a similarly blessed individual." };
            yield return new TextBlock { Id = Guid.Parse("7bb70868-d9f1-4b0a-9d35-fe4c84ddca9a"), Type = TextBlockType.Text, Text = "Grant this new sorcerer bloodline to players who finish the Fists of the Ruby Phoenix Adventure Path. Players can then choose this bloodline for any new sorcerer characters they create for future campaigns." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("db82cc20-5c68-4642-bfd6-396262b290c6"), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("3e3a6737-b13b-448b-bd1c-c689fcf48085"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("cb77532f-1ebf-4e00-bc53-3b505544ae65"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse("11cb9e19-f82d-4232-8811-11e3f8cee3f6"), Spells.Instances.RejuvenatingFlames.ID);
            builder.GainSpecificSpell(Guid.Parse("886811fa-f38e-4ef1-824f-ed07b70ced26"), Spells.Instances.DetectMagic.ID);
            builder.GainSpecificSpell(Guid.Parse("2b395b1a-0b16-46f0-8c6c-3fef7296ea0d"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("c53c97ae-7f40-4964-84e9-af55461ca5a1"), Spells.Instances.SeeInvisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("55caaaa7-2527-4600-8b69-a9796cb1e747"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("1f6043eb-85b1-4851-833f-028f21ba508f"), Spells.Instances.RemoveCurse.ID);
            builder.GainSpecificSpell(Guid.Parse("29e92486-5044-439f-bc47-559d04bbe2f7"), Spells.Instances.BreathOfLife.ID);
            builder.GainSpecificSpell(Guid.Parse("cba2f8ba-12f8-4dce-8864-df029a4c9183"), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse("89d54150-4781-48f1-a47d-2d33b1d6b241"), Spells.Instances.Contingency.ID);
            builder.GainSpecificSpell(Guid.Parse("e8b8ad5f-47ec-4a61-b9cd-bd235fa00303"), Spells.Instances.MomentOfRenewal.ID);
            builder.GainSpecificSpell(Guid.Parse("5c46282d-b3d6-48d0-8ead-2e177bb14acc"), Spells.Instances.MeteorSwarm.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9dd943b3-06fb-4a2c-8bd2-7bd427ac155c"),
                SourceId = Sources.Instances.Pathfinder168.ID,
                Page = 74
            };
        }
    }
}
