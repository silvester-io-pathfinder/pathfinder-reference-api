using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestigatorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("496f2d3d-a240-4f0c-a4ae-ca65e2b7382f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Investigator Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the investigator archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("714c3058-5064-4f23-8e7b-b7af4b8d84b3"), Type = TextBlockType.Text, Text = "You gain the on the case class feature, which grants you both the (feat: Pursue a Lead) activity and (feat: Clue In) reaction. You become trained in Society and another skill of your choice. If you were already trained in Society, you instead become trained in an additional skill of your choice. You also become trained in investigator class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("98bd7535-cf4d-4eb6-963b-95e5ae6d0aa8"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cef8ac9e-a179-436e-b289-a58e55c7d3ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
