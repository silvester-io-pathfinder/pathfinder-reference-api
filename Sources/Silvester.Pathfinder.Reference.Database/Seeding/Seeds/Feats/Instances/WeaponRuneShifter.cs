using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeaponRuneShifter : Template
    {
        public static readonly Guid ID = Guid.Parse("11dffb1e-3201-4a13-b11b-6986bae55aa2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weapon-Rune Shifter",
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
            yield return new TextBlock { Id = Guid.Parse("3e4a80b3-b0ec-4ce7-8feb-b2e189b0ca21"), Type = TextBlockType.Text, Text = "You learn how to alter the magic of weapon runes by using a crystal as a focusing component. Once per day during your daily preparations, you can focus on a rune’s magical energies through a crystal’s facets to alter a single property rune on one weapon in your possession to suppress its normal effects and make it function as a different property rune. You can temporarily alter the rune to function as one of the following runes: (item: corrosive | Corrosive Runestone), (item: flaming | Flaming Runestone), (item: frost | Frost Runestone), (item: ghost touch | Ghost Touch Runestone), (item: grievous | Grievous Runestone), (item: returning | Returning Runestone), (item: shock | Shock Runestone), (item: thundering | Thundering Runestone), or (item: wounding | Wounding Runestone). The property rune remains altered until you make your next daily preparations. The weapon must meet the prerequisites for the temporary rune, and any other runes that required the suppressed rune are also suppressed while the rune is transformed. The rune is obviously altered, and thus the weapon can’t be sold as though it had the temporary rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("780aac68-18ee-4b6e-9335-ad672d09b7e0"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab447570-e081-4f40-9505-a55977ab69e3"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
