using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenaciousToxins : Template
    {
        public static readonly Guid ID = Guid.Parse("b5434765-d832-401c-b7d1-984375d3250a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tenacious Toxins",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("108d7c66-b632-4c7c-a02c-d9d130b5b7b9"), Type = TextBlockType.Text, Text = "Your victims tend to expire long before your poisons, since the latter have been specifically formulated to last longer. The maximum duration of any poison you create increases by an amount equal to the poison’s stage 1 interval, to a maximum of twice the poison’s maximum duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("36f1ece2-05ab-4fe1-9386-266009d6149f"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04d770cd-6b07-4da1-9596-5ed060347577"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
