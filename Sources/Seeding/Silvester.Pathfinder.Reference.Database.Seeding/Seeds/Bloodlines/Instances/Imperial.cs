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
    public class Imperial : Template
    {
        public static readonly Guid ID = Guid.Parse("3de198d9-f399-493d-a77e-b8ebf5f633a6");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Imperial",
                BloodMagic = "A surge of ancestral memories grants you or one target a +1 status bonus to skill checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.AncestralMemories.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ExtendSpell.ID,
                GreaterBloodlineSpellId = Spells.Instances.ArcaneCountermeasure.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f0c2a9ff-cca6-4e7b-92d0-9f1d85478f07"), Type = TextBlockType.Text, Text = "One of your ancestors was a mortal who mastered magic. Such magical blood can remain latent for generations, but in you it manifested in full." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("7a1d80d6-396f-4357-9861-48536c72d35f"), MagicTraditions.Instances.Arcane.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("47522109-ebe6-4a43-b95d-80dc52a90b0d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("1888f03a-186d-4d78-b260-ee270ed793c0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);

            builder.GainSpecificSpell(Guid.Parse("d1ae395e-d785-4fb5-8124-837b5b91fb37"), Spells.Instances.AncestralMemories.ID);
            builder.GainSpecificSpell(Guid.Parse("83b98ad8-b712-4804-aa95-10f777900944"), Spells.Instances.DetectMagic.ID);
            builder.GainSpecificSpell(Guid.Parse("29c4ae52-7e91-43de-a484-1e3ab90ec163"), Spells.Instances.MagicMissile.ID);
            builder.GainSpecificSpell(Guid.Parse("e41072b2-d602-4521-98d5-e9f5fb336670"), Spells.Instances.DispelMagic.ID);
            builder.GainSpecificSpell(Guid.Parse("5adf6d95-ac7b-4b0d-a9c8-1796d08f3376"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("41c7b7d5-0cf7-4278-b646-e2f3abcac031"), Spells.Instances.DimensionDoor.ID);
            builder.GainSpecificSpell(Guid.Parse("9646e5f7-c8bf-4da4-adae-4f651d18872e"), Spells.Instances.PryingEye.ID);
            builder.GainSpecificSpell(Guid.Parse("a7a5963d-337b-4dfc-8155-3247e88e09c1"), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse("a1d27621-003d-4ad0-bd38-80d5351e52a8"), Spells.Instances.PrismaticSpray.ID);
            builder.GainSpecificSpell(Guid.Parse("ed20eb70-ddbc-49c7-aacd-6f6905b3cb06"), Spells.Instances.Maze.ID);
            builder.GainSpecificSpell(Guid.Parse("faf1aef1-d580-48a4-849e-196665f3300e"), Spells.Instances.PrismaticSphere.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Society.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c964c393-16cb-4a22-af65-31114271afa7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
