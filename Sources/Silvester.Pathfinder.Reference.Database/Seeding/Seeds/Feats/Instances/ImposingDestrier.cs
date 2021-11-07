using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImposingDestrier : Template
    {
        public static readonly Guid ID = Guid.Parse("d5a2fd26-41f5-4ed9-b13e-9357c92ed9ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Imposing Destrier",
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
            yield return new TextBlock { Id = Guid.Parse("906d8e76-35e9-43e2-a795-922f04011094"), Type = TextBlockType.Text, Text = "Under your care, your mount has realized its innate potential. The mount you gained through the divine ally class feature is now a nimble or savage animal companion (page 214). During an encounter, even if you don’t use the (action: Command an Animal) action, your mount can still use 1 action on your turn to (action: Stride) or (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("0832a36e-687b-463e-91d1-b743a7e01854"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificFeat(Guid.Parse("2cf31226-f464-44d6-a1bb-1dd2cd13c5c9"), Feats.Instances.LoyalWarhorse.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("984d1b96-a832-4f55-b733-a350eea735e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
