using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueHypercognition : Template
    {
        public static readonly Guid ID = Guid.Parse("73cabe9e-6239-412a-a38b-30f40249f1fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Hypercognition",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f26479aa-c6ae-45c9-80fa-f3774f2a9e58"), Type = TextBlockType.Text, Text = "Your mind works at an incredible pace. You instantly use up to five (action: Recall Knowledge) actions. If you have any special abilities or free actions that would normally be triggered when you (action: Recall Knowledge), you can’t use them for these actions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bd8d14a0-db43-4388-bdd8-3767750bf750"), Feats.Instances.LoremasteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf74d426-b837-408d-a0b9-e11732face0a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
