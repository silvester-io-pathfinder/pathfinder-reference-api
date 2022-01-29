using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TacticalCadence : Template
    {
        public static readonly Guid ID = Guid.Parse("c08c5327-e299-4209-aefb-3dbf38d2a57e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tactical Cadence",
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
            yield return new TextBlock { Id = Guid.Parse("f1f4fae7-4e9c-49e5-8e03-ad2dadac3162"), Type = TextBlockType.Text, Text = $"Your remarkable breath control and concise instructions allow you to coordinate your allies more effectively. When you grant allies the quickened condition using {ToMarkdownLink<Models.Entities.Feat>("Cadence Call", Feats.Instances.CadenceCall.ID)}, they can use the extra action to either {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} or {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, and they aren't slowed 1 on their following turn if they use the extra action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7467d6c1-5a26-4680-ae0d-ebf282899fa5"), Feats.Instances.CadenceCall.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3a380eb-1347-4739-a37d-078c8a9dabed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
