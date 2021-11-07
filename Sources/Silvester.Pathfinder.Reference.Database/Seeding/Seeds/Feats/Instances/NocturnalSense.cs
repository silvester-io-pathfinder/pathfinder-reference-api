using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NocturnalSense : Template
    {
        public static readonly Guid ID = Guid.Parse("18d89e4b-9daa-4dc8-b1e6-e71fedd6537a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nocturnal Sense",
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
            yield return new TextBlock { Id = Guid.Parse("ec7e574d-c9aa-4e1d-865a-0fd0d25c63da"), Type = TextBlockType.Text, Text = "Your senses gain even greater clarity. While raging, you gain darkvision if you don’t already have it, and the range of your imprecise scent increases to 60 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("7f0f6a1a-94a9-4b93-abbf-9111131ec75a"), or => 
            {
                or.AddOr(Guid.Parse("1a90a9f7-a4e8-4a91-aa66-59ea26bd2b1a"), or => 
                {
                    or.HaveSpecificFeat(Guid.Parse("33fba31f-a6a1-4bd4-86ce-433a06441be5"), Feats.Instances.AcuteScent.ID);
                    or.HaveSpecificSense(Guid.Parse("e15c4ac1-d350-4e59-b614-e25264305131"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Precise.ID);
                    or.HaveSpecificSense(Guid.Parse("75d60dca-70ae-4e30-a165-ab09a58602a3"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID);
                });
                or.HaveSpecificSense(Guid.Parse("30e191c5-8ce5-4347-ad96-1aa776c9f203"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e36971c8-40e8-4f34-8eda-864847be4bb3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
