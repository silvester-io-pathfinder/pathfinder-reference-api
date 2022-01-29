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
    public class Undead : Template
    {
        public static readonly Guid ID = Guid.Parse("34b41a54-ecd6-4e24-a6a2-52b44d638476");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Undead",
                BloodMagic = "Necromantic energy flows through you or one target. Either you gain temporary Hit Points equal to the spell's level for 1 round, or a target takes 1 negative damage per spell level (if the spell already deals initial negative damage, combine this with the spell's initial damage before determining weaknesses and resistances).",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.UndeathsBlessing.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DrainLife.ID,
                GreaterBloodlineSpellId = Spells.Instances.GraspingGrave.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6e44824a-776f-42e1-ba2a-4f1f8014c443"), Type = TextBlockType.Text, Text = "The touch of undeath runs through your blood. Your family tree might contain powerful undead, like a vampire, or perhaps you died and returned a bit different." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("e77de193-ce06-472e-9e99-f6eaa15746b3"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("88242a63-4e8d-437f-b9a3-2af3785aedd6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("2f1d954f-0b11-4a98-948d-7182942dacc6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("641c4ccf-f6eb-4175-b3a1-79ebed675eb5"), Spells.Instances.UndeathsBlessing.ID);
            builder.GainSpecificSpell(Guid.Parse("2a643f19-fddd-4a04-b686-3ac020e3ce60"), Spells.Instances.ChillTouch.ID);
            builder.GainSpecificSpell(Guid.Parse("7e9438dd-2432-4e67-8fca-bb4a96154603"), Spells.Instances.Harm.ID);
            builder.GainSpecificSpell(Guid.Parse("61017539-26fa-47bc-813c-689c5e4b549c"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("7e626fde-40ca-4b88-a8f1-a7f4bda11426"), Spells.Instances.BindUndead.ID);
            builder.GainSpecificSpell(Guid.Parse("d1fbaeec-59f2-4364-b1f5-2cbe14c6397e"), Spells.Instances.TalkingCorpse.ID);
            builder.GainSpecificSpell(Guid.Parse("266b3d26-3fbe-4170-ba16-23cbd5c8ca5b"), Spells.Instances.Cloudkill.ID);
            builder.GainSpecificSpell(Guid.Parse("4fe9696b-68c0-45aa-b735-44015b049694"), Spells.Instances.VampiricExsanguination.ID);
            builder.GainSpecificSpell(Guid.Parse("7008c027-ea5c-486e-81a5-58d8532c1c85"), Spells.Instances.FingerOfDeath.ID);
            builder.GainSpecificSpell(Guid.Parse("9e6195ce-a1ef-481c-8362-62611c375d54"), Spells.Instances.HorridWilting.ID);
            builder.GainSpecificSpell(Guid.Parse("ea845386-31be-4d88-8ead-3ce3bb86afab"), Spells.Instances.WailOfTheBanshee.ID);
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
                Id = Guid.Parse("d0bfef89-808e-4a45-9fe9-d12a2691e516"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
