using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessedBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("cb3d4a8c-936e-4a67-a0b8-d3f4394940e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Blood",
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
            yield return new TextBlock { Id = Guid.Parse("f700b4a2-1af5-4862-8a6f-7eb06030acab"), Type = TextBlockType.Text, Text = "Your deity’s blessings manifest in your blood-borne power. Add up to three of your deity’s spells (spells your deity grants to clerics) to your spell list. They are not automatically added to your repertoire, but you can select them just as you would spells normally on the divine spell list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyBloodlineSpecificMagicTradition(Guid.Parse("4d1bc976-67d1-4eb5-87db-fd3ec9e7bb1f"), MagicTraditions.Instances.Divine.ID);
            builder.FollowAnyReligion(Guid.Parse("77552b26-e41b-4af7-a2d9-83d3a02bd9a7"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a174b53e-fb42-4e5f-b8a1-ba8d337b2148"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
