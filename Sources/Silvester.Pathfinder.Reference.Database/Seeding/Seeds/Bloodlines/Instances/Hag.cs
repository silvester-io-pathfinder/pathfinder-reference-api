using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Hag : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Hag",
                BloodMagic = "Spiteful curses punish your foes. The first creature that deals damage to you before the end of your next turn takes 2 mental damage per spell level and must attempt a basic Will save.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.JealousHex.ID,
                AdvancedBloodlineSpellId = Spells.Instances.HorrificVisage.ID,
                GreaterBloodlineSpellId = Spells.Instances.YoureMine.ID,
                SpellListTraditionId = MagicTraditions.Instances.Occult.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A hag long ago cursed your family, or you are a descendant of a hag or changeling, and their accursed corruption infests your blood and soul." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Occult.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.JealousHex.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Daze.ID );
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID );
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TouchOfIdiocy.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Blindness.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.OutcastsCurse.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MarinersCurse.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BalefulPolymorph.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpMind.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiritualEpidemic.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.NaturesEnmity.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Occultism.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 197
            };
        }
    }
}
