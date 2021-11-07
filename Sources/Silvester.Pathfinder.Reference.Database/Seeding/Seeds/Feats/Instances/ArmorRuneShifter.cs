using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmorRuneShifter : Template
    {
        public static readonly Guid ID = Guid.Parse("b7c097d8-d511-4f45-a863-0bcf0ebab2e0");

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
            yield return new TextBlock { Id = Guid.Parse("c277d5a2-9b1e-4e8a-9de8-8c296dcddc28"), Type = TextBlockType.Text, Text = "You learn the secrets of armor runes by viewing them through gems and can alter them at your discretion. Once per day when you make your daily preparations, you can focus on a rune’s magical energies through a crystal’s facets to alter a single property rune on one suit of armor in your possession to suppress its normal effects and make it function as a different property rune. You can temporarily alter the rune to function as one of the following runes: (item: energy resistant | Energy-Resistant Runestone), (item: fortification | Fortification Runestone), (item: glamered | Glamered Runestone), (item: invisibility | Invisibility Runestone), (item: shadow | Shadow Runestone), or (item: slick | Slick Runestone). The property rune remains altered until you make your next daily preparations. The armor must meet the prerequisites for the temporary rune, and any other runes that required the suppressed rune are also suppressed while the rune is transformed. The rune is obviously altered, and thus the armor can’t be sold as though it had the temporary rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f47d2b62-b18b-418a-9737-74a8ac8bb918"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa61b80a-e576-465b-a304-9166de6c2abe"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
