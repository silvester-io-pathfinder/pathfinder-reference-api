using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmorRuneShifter : Template
    {
        public static readonly Guid ID = Guid.Parse("2f0b0b7f-fe59-473c-aec6-c8737f89fbe1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor-Rune Shifter",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("090d5130-faa1-45a5-9231-af9cc1496656"), Type = TextBlockType.Text, Text = $"You learn the secrets of armor runes by viewing them through gems and can alter them at your discretion. Once per day when you make your daily preparations, you can focus on a rune's magical energies through a crystal's facets to alter a single property rune on one suit of armor in your possession to suppress its normal effects and make it function as a different property rune. You can temporarily alter the rune to function as one of the following runes: {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("energy resistant", Items.ArmorPropertyRunes.Instances.EnergyResistant.ID)}, {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("fortification", Items.ArmorPropertyRunes.Instances.Fortification.ID)}, {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("glamered", Items.ArmorPropertyRunes.Instances.Glamered.ID)}, {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("invisibility", Items.ArmorPropertyRunes.Instances.Invisibility.ID)}, {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("shadow", Items.ArmorPropertyRunes.Instances.Shadow.ID)}, or {ToMarkdownLink<Models.Items.Instances.ArmorPropertyRune>("slick", Items.ArmorPropertyRunes.Instances.Slick.ID)}. The property rune remains altered until you make your next daily preparations. The armor must meet the prerequisites for the temporary rune, and any other runes that required the suppressed rune are also suppressed while the rune is transformed. The rune is obviously altered, and thus the armor can't be sold as though it had the temporary rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7add5051-e158-4b98-9732-a4371ca1f89e"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfba3dde-9a89-4541-b151-366c02f6f7bd"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
