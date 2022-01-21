using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KiCenter : Template
    {
        public static readonly Guid ID = Guid.Parse("7425e376-a3ef-4707-b194-f20a19ffa070");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ki Center",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19ead337-c8b4-4fe8-8fc4-d2f386ba1c84"), Type = TextBlockType.Text, Text = "You center yourself with the universe and draw upon its vast power. You cast a single action ki spell with the stance trait, without spending a Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("313efd76-170b-49c2-bd08-41873c1af2f0"));
            builder.HaveSpecificFeat(Guid.Parse("3c69ab7a-3848-4cff-8ef4-a04fcccddc9a"), Feats.Instances.MasterOfManyStyles.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6abbbf5-d7db-4578-a5dd-e17dea6417fa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
