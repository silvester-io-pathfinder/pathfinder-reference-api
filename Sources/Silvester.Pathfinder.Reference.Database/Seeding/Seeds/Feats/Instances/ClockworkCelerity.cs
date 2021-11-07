using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClockworkCelerity : Template
    {
        public static readonly Guid ID = Guid.Parse("3492b0b6-7e16-411b-9596-d2bc35a99287");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clockwork Celerity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e555eac7-b7e9-4951-9952-4d141f8c2769"), Type = TextBlockType.Text, Text = "You can use unstable clockwork devices in your innovation to push your invention to act more quickly. You are quickened for this turn. How you can use the extra action depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("a299e089-a10a-4b8c-8a48-1584540677b6"), Type = TextBlockType.Enumeration, Text = " Armor: You can use the extra action to (action: Step), (action: Stride), or use another movement action granted by your innovation (such as (action: Swim) if you have the (feat: Diving Armor) feat)." };
            yield return new TextBlock { Id = Guid.Parse("b9c68619-d226-40de-a082-9120a2628286"), Type = TextBlockType.Enumeration, Text = " Construct: You can use the extra action to Command your construct innovation (or to provide 1 of the actions if you spend 2 actions to Command your construct)." };
            yield return new TextBlock { Id = Guid.Parse("8d8dc28c-3bb1-42ec-818e-3d841deb2fa8"), Type = TextBlockType.Enumeration, Text = " Weapon: You can use the extra action to (action: Strike) with your innovation or Reload your innovation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("0f39517c-f465-453a-af83-4d56344eb097"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("a298d875-9405-4723-a2eb-87e75e6fa4dd"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("d135a4eb-5fc2-46e4-9824-ef47933a59f7"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("d44c4567-98fd-443a-a985-a545d931c148"), Innovations.Instances.Weapon.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef0bcee6-86cf-4654-9388-339ac15f29c3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
