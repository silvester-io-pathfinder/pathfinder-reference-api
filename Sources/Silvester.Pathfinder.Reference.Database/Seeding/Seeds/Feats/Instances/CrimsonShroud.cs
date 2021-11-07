using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrimsonShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("04db0dd3-7801-4a96-8f8e-4103c11f478f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crimson Shroud",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "A number of times per day equal to your number of class feats from the Red Mantis assassin archetype"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85e0521d-9598-4545-b6d6-d1f86f3003b8"), Type = TextBlockType.Text, Text = "You swathe yourself in a veil of red mist for 1 minute. While the shroud is active, you gain fast healing equal to half your level. You can (action: Interact) with your shroud, swirling it around you, to gain a +1 circumstance bonus to AC until the beginning of your next turn. Finally, if you die while the shroud is active, you can choose to have your entire body vanish into red mist, leaving behind only your gear; you make this choice when you activate Crimson Shroud." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1411798-d6b7-42b4-9b46-785dc33c8389"), Feats.Instances.RedMantisAssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83f45cce-7748-41cb-a459-fa688fbafccd"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
