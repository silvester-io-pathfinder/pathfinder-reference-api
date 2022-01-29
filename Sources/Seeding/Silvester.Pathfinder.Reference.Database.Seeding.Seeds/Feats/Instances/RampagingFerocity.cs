using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RampagingFerocity : Template
    {
        public static readonly Guid ID = Guid.Parse("85b8f7e7-8033-4933-b313-627faf9b7630");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rampaging Ferocity",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Orc Ferocity.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e350e44-df7c-43a2-ba9b-962102958b15"), Type = TextBlockType.Text, Text = $"You lash out viciously even as you fend off death. Make a single melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} brings a foe to 0 Hit Points, this activation of {ToMarkdownLink<Models.Entities.Feat>("Orc Ferocity", Feats.Instances.OrcFerocity.ID)} doesn't count against its frequency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("07dd20b6-0590-4260-9afa-ac320dc2faa8"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("211deef8-aa2f-4c04-827a-a8349e91c5c5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
