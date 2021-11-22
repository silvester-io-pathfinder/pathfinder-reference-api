using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheVanguard : Template
    {
        public static readonly Guid ID = Guid.Parse("ada78c07-32d9-4409-b6ff-3f44a9f83089");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Vanguard",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab99418b-93e3-4a30-a514-b3e67d95ebec"), Type = TextBlockType.Text, Text = "You practice a style of shooting that seeks to ensure that your first shot is perfectly placed. You keep hidden or at a distance, staying out of the fray and bringing unseen death to your foes." };
            yield return new TextBlock { Id = Guid.Parse("2bb9f7ac-63fa-460a-a5a1-b7e3583d4fa5"), Type = TextBlockType.Text, Text = "~ Slinger's Reload: (feat: Clear a Path)" };
            yield return new TextBlock { Id = Guid.Parse("432ff57f-c6d2-4159-a305-af9bba056978"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Living Fortification); __Advanced__ (feat: Spinning Crush); __Greater__ (feat: Siegebreaker)" };
            yield return new TextBlock { Id = Guid.Parse("30bbd042-2f83-4b02-b7d5-640e5e8e3548"), Type = TextBlockType.Text, Text = "~ Way Skill: Athletics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c5cd718-e41d-4af9-99ca-96b8f3ce22bc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
