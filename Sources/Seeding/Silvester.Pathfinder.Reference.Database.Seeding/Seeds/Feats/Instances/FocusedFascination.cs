using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusedFascination : Template
    {
        public static readonly Guid ID = Guid.Parse("e1a63c6d-d953-4dab-9c7b-e1d038b38c7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Fascination",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d27366f-ea68-456d-9cc6-0f44cecff9e0"), Type = TextBlockType.Text, Text = "When you use (feat: Fascinating Performance) in a combat encounter, you need only a success, rather than a critical success, to fascinate your target. This works only if you’re attempting to fascinate one target. For example, if you were an expert in Performance, you could choose to target multiple creatures normally or target one creature and fascinate it on a success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ca269a4-90c4-427d-9996-5668849a11ee"), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58e1db11-2b83-4d3f-8743-97ee67c24fdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
