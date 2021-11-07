using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedTwinRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("248bae42-5f59-4ec4-b139-0688cf4d2218");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Twin Riposte",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("308736cc-725c-42ab-a1e2-19e222899033"), Type = TextBlockType.Text, Text = "Your weapons are a blur, blocking and biting at your foes. At the start of each of your turns, you gain an additional reaction that you can use only to perform a (feat: Twin Riposte). You can use this extra reaction even if you are not benefiting from (feat: Twin Parry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("457948f1-a512-41fc-9840-76125c6c33ad"), Feats.Instances.TwinRiposte.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58b09ae2-0201-4361-a606-f84a7588489c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
