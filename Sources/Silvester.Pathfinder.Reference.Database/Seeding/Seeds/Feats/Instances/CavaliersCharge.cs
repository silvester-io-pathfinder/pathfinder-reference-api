using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CavaliersCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("d8c6602f-5ac4-423f-97ab-6b5264c64392");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cavalier's Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e0533da-ba04-48ae-8d64-71bfe6a9918c"), Type = TextBlockType.Text, Text = "You (action: Command an Animal) to order your mount to (action: Stride) twice. At any point during this movement, you can (action: Strike) one enemy within reach or within the first range increment of a ranged weapon. You gain a +1 circumstance bonus to your attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b2d486f0-f1b0-45cd-997c-105c864e1303"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1399bad-8bb3-4228-bda2-beba4c80c979"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
