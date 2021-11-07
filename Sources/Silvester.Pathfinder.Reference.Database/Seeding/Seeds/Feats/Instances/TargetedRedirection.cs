using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TargetedRedirection : Template
    {
        public static readonly Guid ID = Guid.Parse("ce9f208d-fa5e-45cf-9b11-505ff98d9aec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Targeted Redirection",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f58b88a2-6c98-4d6e-bc83-0e486fab8275"), Type = TextBlockType.Text, Text = "You aim a shot at your spotter, intending for your spotter to redirect that shot off their own weapon or shield to hit your foe from a better angle, and avoid your foe’s cover. If your next action is to make a ranged (action: Strike), you treat your spotter’s position as your own for the purposes of determining cover and range. Your spotter must be within your weapon’s first range increment and they must use a reaction to redirect your shot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4e18c65d-f47c-4c5a-856d-1aa837b6122b"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80be9652-a19a-431d-bf45-d34794a6fb4e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
