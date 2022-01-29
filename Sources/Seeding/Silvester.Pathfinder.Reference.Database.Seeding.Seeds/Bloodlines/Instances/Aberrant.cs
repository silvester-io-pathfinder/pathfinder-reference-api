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
    public class Aberrant : Template
    {
        public static readonly Guid ID = Guid.Parse("f9da3a44-ec9c-41dc-8021-16a3c3023792");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Aberrant",
                BloodMagic = "Aberrant whispers shield one target's mind or your own, granting a +2 status bonus to Will saving throws for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.TentacularLimbs.ID,
                AdvancedBloodlineSpellId = Spells.Instances.AberrantWhispers.ID,
                GreaterBloodlineSpellId = Spells.Instances.UnusualAnatomy.ID,
                SpellListTraditionId = MagicTraditions.Instances.Occult.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("644ba070-32df-4818-a79d-c43fffb36302"), Type = TextBlockType.Text, Text = "Something speaks to you from beyond the stars or below the earth. Ancient and unknowable, this alien influence presses against your mind." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("2cc4a194-35b8-4f72-be29-b7689c9b8142"), MagicTraditions.Instances.Occult.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("8bb98c6e-27a9-4062-872a-b6eaadad0be1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("c61e6bbf-1446-4070-ac27-c715c10a4f87"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);

            builder.GainSpecificSpell(Guid.Parse("3443f7a0-6ce9-486b-96f9-b54163d83daa"), Spells.Instances.TentacularLimbs.ID);
            builder.GainSpecificSpell(Guid.Parse("b009daaf-b081-40a1-a4ca-4886cdd6a6b2"), Spells.Instances.Daze.ID);
            builder.GainSpecificSpell(Guid.Parse("ea084e9f-95f6-464a-9d4a-18647c7ac9b5"), Spells.Instances.SpiderSting.ID);
            builder.GainSpecificSpell(Guid.Parse("67bf6de1-e77b-42d8-917b-8982a89435bb"), Spells.Instances.TouchOfIdiocy.ID);
            builder.GainSpecificSpell(Guid.Parse("b6b4baf3-68af-44b0-8da9-5c34b3f834cd"), Spells.Instances.VampiricTouch.ID);
            builder.GainSpecificSpell(Guid.Parse("fc25bff2-09e0-4c77-af23-73a4f769599e"), Spells.Instances.Confusion.ID);
            builder.GainSpecificSpell(Guid.Parse("0561510a-9783-43b1-b74d-77538232cac2"), Spells.Instances.BlackTentacles.ID);
            builder.GainSpecificSpell(Guid.Parse("4a0f78ba-3b1c-4dd6-8acf-2ee93cd2525f"), Spells.Instances.Feeblemind.ID);
            builder.GainSpecificSpell(Guid.Parse("d9fc935e-1900-4559-a3a0-788b4cbf9344"), Spells.Instances.WarpMind.ID);
            builder.GainSpecificSpell(Guid.Parse("45a5f614-f996-4f3a-af36-4d5d11db62db"), Spells.Instances.UncontrollableDance.ID);
            builder.GainSpecificSpell(Guid.Parse("e9d41528-bfc8-49f0-b712-26abed8cba7c"), Spells.Instances.UnfathomableSong.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Occultism.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3965ad91-2eee-422a-9a55-2eb0f0465ee2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 195
            };
        }
    }
}
