using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElaborateTalismanEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("f8aa41c5-32e6-49ef-af51-239b55d8e74a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elaborate Talisman Esoterica",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("effbc558-eb8b-4151-a879-fa08226a0fd6"), Type = TextBlockType.Text, Text = "As you continue to collect talismanic esoterica, you improve your ability to create temporary talismans. You can create four temporary talismans each day instead of two" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("918682c7-bcfd-4e8f-90d5-ce7619ea3e21"), Feats.Instances.TalismanEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36749d71-cd19-4eec-abaf-2d4e49d73d82"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
