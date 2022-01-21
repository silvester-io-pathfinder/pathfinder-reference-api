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
    public class Psychopomp : Template
    {
        public static readonly Guid ID = Guid.Parse("9959ed3e-6d9a-40ac-b593-d829c3c7ce5d");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Psychopomp",
                BloodMagic = "The border between life and death becomes blurred to you. Either you gain a +2 status bonus to Fortitude saving throws for 1 round, or a target takes 1 damage per spell level. The damage is negative if the target is living or positive if the target is undead. If the spell already deals that type of damage, combine it with the spell's initial damage before determining weaknesses and resistances.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.SepulchralMask.ID,
                AdvancedBloodlineSpellId = Spells.Instances.SpiritVeil.ID,
                GreaterBloodlineSpellId = Spells.Instances.ShepherdOfSouls.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("56c52c39-fab1-4ab0-8e18-3642a9f1b791"), Type = TextBlockType.Text, Text = "For good or ill, your ancestors' deeds drew the attention of psychopomps, or you might somehow count one in your family tree. The presence of these shepherds of souls and enemies of undeath has left an indelible mark on you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("fe4a8ca1-da53-4b24-a06d-bf7b9369fa25"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("dfbb569b-6e39-4b94-90c2-4adc1b6abe8e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("21b8c2b1-c825-432c-92cc-8edea86a39cc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("13ae5d03-8ceb-44a4-824f-c4776496d15d"), Spells.Instances.SepulchralMask.ID);
            builder.GainSpecificSpell(Guid.Parse("c0d24e9f-bf11-4b12-9e48-9e2687d495ca"), Spells.Instances.DisruptUndead.ID);
            builder.GainSpecificSpell(Guid.Parse("0965cf4f-7b46-433d-8ac4-8f6d61a30e47"), Spells.Instances.Heal.ID);
            builder.GainSpecificSpell(Guid.Parse("91cfe0d8-4407-4ffc-9c9e-f231a99e7662"), Spells.Instances.CalmEmotions.ID);
            builder.GainSpecificSpell(Guid.Parse("84c1128b-e33b-4309-a6ca-8893de996906"), Spells.Instances.SearingLight.ID);
            builder.GainSpecificSpell(Guid.Parse("d7e6427e-8d1c-404c-9f45-4d54d7a57785"), Spells.Instances.DimensionalAnchor.ID);
            builder.GainSpecificSpell(Guid.Parse("4adf008e-ae0d-4627-b513-d05fa46a4676"), Spells.Instances.DeathWard.ID);
            builder.GainSpecificSpell(Guid.Parse("cfe01f00-3c4a-45ad-acd3-e33c9b5c2d9a"), Spells.Instances.SpiritBlast.ID);
            builder.GainSpecificSpell(Guid.Parse("a4125445-df4b-47e5-8d5f-eb179292f732"), Spells.Instances.FingerOfDeath.ID);
            builder.GainSpecificSpell(Guid.Parse("cc67cc7a-4fbd-4d6f-821d-722a5257572d"), Spells.Instances.SpiritSong.ID);
            builder.GainSpecificSpell(Guid.Parse("ab551a87-261d-4edb-8911-41fbff27eec7"), Spells.Instances.Massacre.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25d11f9e-cb20-4874-9d7c-60462d8ec8bb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
