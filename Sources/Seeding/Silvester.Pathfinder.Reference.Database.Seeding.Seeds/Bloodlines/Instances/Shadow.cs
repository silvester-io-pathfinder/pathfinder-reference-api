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
    public class Shadow : Template
    {
        public static readonly Guid ID = Guid.Parse("f6b74274-9bc5-4781-975a-01555464148f");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Shadow",
                BloodMagic = "Shadows grow deeper around you or one target, either granting a +1 status bonus to Stealth or imposing a -1 status penalty to Perception for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DimTheLight.ID,
                AdvancedBloodlineSpellId = Spells.Instances.StealShadow.ID,
                GreaterBloodlineSpellId = Spells.Instances.ConsumingDarkness.ID,
                SpellListTraditionId = MagicTraditions.Instances.Occult.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("af1d7959-4d88-4fd7-9442-c1dcdc4260b5"), Type = TextBlockType.Text, Text = "Whether due to a velstrac's manipulations or a planar jaunt gone horribly wrong, your bloodline was infused with a vein of shadow." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("07c99774-3cfb-4d7c-baa4-f4d126ef1131"), MagicTraditions.Instances.Occult.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("7b2f20b6-8977-4319-9927-62d59f8761cb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("7c218861-b898-4b50-a38e-58e2b1c22db4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);

            builder.GainSpecificSpell(Guid.Parse("8ee99a73-d7c3-4b5d-8559-d7c2e674a050"), Spells.Instances.DimTheLight.ID);
            builder.GainSpecificSpell(Guid.Parse("cbcab9cf-1e7d-46a9-bc5d-c18035b31d9f"), Spells.Instances.ChillTouch.ID);
            builder.GainSpecificSpell(Guid.Parse("832dc237-bc83-468d-aae5-b55f3ef9c431"), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse("da8982c2-bfef-457c-b9e0-4e08efc8830d"), Spells.Instances.Darkness.ID);
            builder.GainSpecificSpell(Guid.Parse("dd708eaf-981a-4173-9af2-9e8ba2b9decf"), Spells.Instances.ChillingDarkness.ID);
            builder.GainSpecificSpell(Guid.Parse("6fdae03e-2ff7-4eea-8f2d-b11859092db5"), Spells.Instances.PhantasmalKiller.ID);
            builder.GainSpecificSpell(Guid.Parse("66f140ea-3954-469d-b4f8-32167b37219b"), Spells.Instances.ShadowSiphon.ID);
            builder.GainSpecificSpell(Guid.Parse("4312bcd6-c9b7-41cf-bd06-96e1a05e3895"), Spells.Instances.CollectiveTransposition.ID);
            builder.GainSpecificSpell(Guid.Parse("0ece0948-331f-43ac-bdc7-688e23f8d40c"), Spells.Instances.DuplicateFoe.ID);
            builder.GainSpecificSpell(Guid.Parse("619d3efa-0a06-438d-81ec-4269df10d8fd"), Spells.Instances.Disappearance.ID);
            builder.GainSpecificSpell(Guid.Parse("b66a1fb7-6f2f-4650-9f31-3e16efbec0e0"), Spells.Instances.Weird.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Occultism.ID;
            yield return Skills.Instances.Stealth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ac24509-7468-4894-81bb-a14596440623"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
