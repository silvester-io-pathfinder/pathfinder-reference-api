using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes.Instances
{
    public class BabaYaga : Template
    {
        public static readonly Guid ID = Guid.Parse("537961cf-74da-46cd-b5a3-d7262e2b870e");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Baba Yaga",
                Description = "Baba Yaga teaches you how to transfer spirits into objects and freeze your foes. A witch with Baba Yaga as their patron can choose an inanimate object as a familiar. If they do, they still can gain master abilities and some familiar abilities that don�t require movement. The object familiar has no Speeds and must select a Speed familiar ability before it can move, coming to life in a way appropriate to the chosen Speed and using the statistics of a normal familiar for that day.",
                RarityId = Rarities.Instances.Rare.ID,
                PatronSkillId = Skills.Instances.Occultism.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.ChillingSpray.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("0d7c9363-8ba7-48f8-afcb-1bc41022ce0f"), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("324c74ce-57e3-4c55-8a3e-4f218d07d775"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSpell(Guid.Parse("6470b239-9a4c-4803-b240-5a6fffaed92d"), Spells.Instances.SpiritObject.ID);
            builder.GainSpecificSpell(Guid.Parse("d0448c25-5ddd-454d-96e7-12744b2feb56"), Spells.Instances.ChillingSpray.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4091695b-c2fc-4042-9c22-048ef3dcc224"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 32
            };
        }
    }
}
