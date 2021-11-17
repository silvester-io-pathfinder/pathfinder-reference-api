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
        public static readonly Guid ID = Guid.Parse("31b8729e-35c1-4eba-8a21-9552a5a6bf56");
        
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
            yield return new TextBlock { Id = Guid.Parse("38a92ec2-844e-4b91-88a4-1907efb2232d"), Type = TextBlockType.Text, Text = "A hag long ago cursed your family, or you are a descendant of a hag or changeling, and their accursed corruption infests your blood and soul." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("628c2c54-5ac4-4e2c-b328-61c81d03d9be"), MagicTraditions.Instances.Occult.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("5e8a6c83-5dd1-4945-8c4a-c60c28935e92"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("87a44117-e08d-461b-88e2-60809421a65e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);

            builder.GainSpecificSpell(Guid.Parse("0b49fa1b-c24a-4d05-974c-67fc7b733dc2"), Spells.Instances.JealousHex.ID);
            builder.GainSpecificSpell(Guid.Parse("2af39a2b-1b78-4899-a2cd-161f2e0057f4"), Spells.Instances.Daze.ID );
            builder.GainSpecificSpell(Guid.Parse("56f3647a-3d0f-42e4-847e-a74a4722030d"), Spells.Instances.IllusoryDisguise.ID );
            builder.GainSpecificSpell(Guid.Parse("1c9e9091-3c2b-4e86-a4b2-44153b28a648"), Spells.Instances.TouchOfIdiocy.ID);
            builder.GainSpecificSpell(Guid.Parse("b3707309-a14c-43e0-a850-486cd5f9c8fb"), Spells.Instances.Blindness.ID);
            builder.GainSpecificSpell(Guid.Parse("3b1ddf77-c7d4-4f75-9a45-5f5499ed1327"), Spells.Instances.OutcastsCurse.ID);
            builder.GainSpecificSpell(Guid.Parse("09304c98-14ff-4c6f-813d-0460bdbf12e6"), Spells.Instances.MarinersCurse.ID);
            builder.GainSpecificSpell(Guid.Parse("ac334a3f-bb1c-45eb-aa7f-34d411d631c5"), Spells.Instances.BalefulPolymorph.ID);
            builder.GainSpecificSpell(Guid.Parse("65929eb0-bf6f-4631-a231-5651dbad80e6"), Spells.Instances.WarpMind.ID);
            builder.GainSpecificSpell(Guid.Parse("3c00661c-2046-436d-8b9f-d3963da5e1fb"), Spells.Instances.SpiritualEpidemic.ID);
            builder.GainSpecificSpell(Guid.Parse("e76df715-310b-4674-88ab-63812e470f63"), Spells.Instances.NaturesEnmity.ID);
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
                Id = Guid.Parse("1e23bedc-5e7b-4d0b-a45f-31c8a18093e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 197
            };
        }
    }
}
