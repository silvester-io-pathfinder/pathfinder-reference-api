using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RuShi : Template
    {
        public static readonly Guid ID = Guid.Parse("09f6873c-7f84-4244-adca-bc44a2dbaed5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ru-Shi",
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
            yield return new TextBlock { Id = Guid.Parse("349f61b9-46fc-4676-80bb-ec9380565d0c"), Type = TextBlockType.Text, Text = "You were born to a jiang-shi, one of the so-called hopping vampires found most often in Tian-Xia. Your parent had a supernatural obsession with counting small objects, which manifests in you as a preternatural gift for linguistics and mathematics. You are trained in Society and gain the (feat: Eye for Numbers) skill feat. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9a9e0bf-da24-4e5a-aeef-5436583abcdb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
