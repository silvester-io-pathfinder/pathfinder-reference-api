using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StealthyCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("8a772703-7e0e-43c5-8ae8-5c7e79d32a96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stealthy Companion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0c804b66-ecb5-46ca-b4b5-2e29707789d8"), Type = TextBlockType.Text, Text = "You’ve trained your animal companion to blend in to its surroundings. Your animal companion gains the benefit of the (feat: Camouflage) feat. If your companion is a specialized ambusher, its proficiency rank for Stealth increases to master (or legendary if it was already master)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyAnimalCompanion(Guid.Parse("3b8832cd-b941-4de8-86f0-808f6766b8c4"));
            builder.HaveSpecificFeat(Guid.Parse("71f7f79d-63c1-47fa-a70c-a5bc52398089"), Feats.Instances.Camouflage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("110e6fb1-6979-41e2-903c-11c6395e917d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
