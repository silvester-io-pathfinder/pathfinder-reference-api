using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("ac42550c-c134-409e-89fb-6de0b0412fdf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Recollection",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5f54a7d-e436-4d1b-84fa-55ac84fb154e"), Type = TextBlockType.Text, Text = "You can sift through knowledge locked within your mind at an incredible pace. You instantly use up to 5 (action: Recall Knowledge) actions. If you have any special abilities or free actions that would normally be triggered when you (action: Recall Knowledge), you can&#39;t use them for these actions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65389764-7cbe-429a-accd-ef66f97ff76c"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56a2799c-9911-4517-9129-8f7a58ffa328"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
