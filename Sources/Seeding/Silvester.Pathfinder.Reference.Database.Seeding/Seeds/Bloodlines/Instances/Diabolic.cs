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
    public class Diabolic : Template
    {
        public static readonly Guid ID = Guid.Parse("cb866969-064d-4ff8-820d-1ffeef7f6c14");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Diabolic",
                BloodMagic = "Hellfire scorches a target or fills your tongue with lies. Either a target takes 1 fire damage per spell level (if the spell already deals initial fire damage, combine this with the spell�s initial damage before determining weaknesses and resistances), or you gain a +1 status bonus to Deception checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DiabolicEdict.ID,
                AdvancedBloodlineSpellId = Spells.Instances.EmbraceThePit.ID,
                GreaterBloodlineSpellId = Spells.Instances.HellfirePlume.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("48f09a8b-84e6-4f31-985d-47cd7088d906"), Type = TextBlockType.Text, Text = "Devils are evil with a silver tongue, and one of your ancestors dallied in darkness or made an infernal pact." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("a010f096-9267-4130-b322-00febfe80010"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("2c0d0b26-0bc6-4e35-9de9-ca0fb7408745"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("8c970a64-0e49-4982-9c17-9ef56b8830e8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("1cd6ac61-417a-4105-b9b5-a590d14f98be"), Spells.Instances.DiabolicEdict.ID);
            builder.GainSpecificSpell(Guid.Parse("afac090f-6521-459f-8e7f-557988644c2c"), Spells.Instances.ProduceFlame.ID);
            builder.GainSpecificSpell(Guid.Parse("b46514f4-d70d-4f81-b115-ae1b975b46b9"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("f73aef6a-76c9-498f-bb0f-00419f61fdce"), Spells.Instances.FlamingSphere.ID);
            builder.GainSpecificSpell(Guid.Parse("7c95c2fd-fbc8-41de-aa0f-f161b660edc8"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("2c93dcb7-0a92-478b-8729-77ccd1f9baba"), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("0e5d2f1d-7538-4936-8341-4c298c81b3af"), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse("38119449-00fe-4532-9400-275b98bb1ca7"), Spells.Instances.TrueSeeing.ID);
            builder.GainSpecificSpell(Guid.Parse("2d1d8465-fa7c-4f95-9992-cc40c08f4b15"), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse("1146453a-6dbf-478c-bf4d-58290ac68875"), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse("582acbb9-a365-4741-b6d9-8191d1186fb9"), Spells.Instances.MeteorSwarm.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49beb392-a690-40f9-8bbe-ad882c2e3721"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 196
            };
        }
    }
}
