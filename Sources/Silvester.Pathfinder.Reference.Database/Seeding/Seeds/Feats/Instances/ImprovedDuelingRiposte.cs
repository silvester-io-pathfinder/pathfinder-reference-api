using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedDuelingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("ae8154c4-35e3-4cd5-b585-06ada571b7ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Dueling Riposte",
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
            yield return new TextBlock { Id = Guid.Parse("f8865d43-31e5-4bc5-854a-2c9a0cb90d83"), Type = TextBlockType.Text, Text = "Your weapon whirls and darts, striking foes whenever the opportunity presents itself. At the start of each of your turns, you gain an additional reaction that you can use only to make a (feat: Dueling Riposte). You can use this extra reaction even if you are not benefiting from (feat: Dueling Parry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("249ca964-5fef-41ec-b153-7fb9875af56e"), Feats.Instances.DuelingRiposte.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38a6f3dc-d02d-40c7-ae69-77ea94fa8fc3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
