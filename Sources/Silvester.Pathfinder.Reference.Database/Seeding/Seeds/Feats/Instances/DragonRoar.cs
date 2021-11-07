using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonRoar : Template
    {
        public static readonly Guid ID = Guid.Parse("e870e22d-e3a7-4fa6-b9dc-4a6237abe409");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Roar",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b60dea8-f4f4-4628-9099-60092906fa73"), Type = TextBlockType.Text, Text = "You bellow, instilling fear in your enemies. Enemies within a 15-foot emanation must succeed at a Will save against your Intimidation DC or be frightened 1 (frightened 2 on a critical failure). When a creature frightened by the roar begins its turn adjacent to you, it can’t reduce its frightened value below 1 on that turn. Your first attack that hits a frightened creature after you roar and before the end of your next turn gains a +4 circumstance bonus to damage." };
            yield return new TextBlock { Id = Guid.Parse("b64e5228-f1d1-4456-bba7-d722ce4f357d"), Type = TextBlockType.Text, Text = "After you use Dragon Roar, you can’t use it again for 1d4 rounds. Its effects end immediately if you leave (feat: Dragon Stance). Creatures in the area of your roar are then temporarily immune for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b75af24c-ae75-4a7b-8fc9-ab91eef744d7"), Feats.Instances.DragonStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c8c5a4e-acad-4c53-b64e-1435e7b6ba7b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
