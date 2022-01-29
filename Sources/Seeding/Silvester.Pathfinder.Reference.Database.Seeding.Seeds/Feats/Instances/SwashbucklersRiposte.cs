using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwashbucklersRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("8fc1513e-f236-4559-bc6a-c90d30b2fa69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swashbuckler's Riposte",
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
            yield return new TextBlock { Id = Guid.Parse("5140a4e1-1346-4d1e-997e-a0980d2708ca"), Type = TextBlockType.Text, Text = $"You've learned to riposte against ill-conceived attacks. You gain the {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)} reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a314ff49-b45d-4a35-b759-9481e6fc6467"), Feats.Instances.SwashbucklerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d4097a0-1a3b-400c-a9f9-502fbc361cc7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
