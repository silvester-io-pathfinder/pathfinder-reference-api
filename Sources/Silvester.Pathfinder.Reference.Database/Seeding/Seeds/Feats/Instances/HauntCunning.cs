using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HauntCunning : Template
    {
        public static readonly Guid ID = Guid.Parse("54caae71-3d41-494c-9609-a27a7a6de5ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Haunt Cunning",
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
            yield return new TextBlock { Id = Guid.Parse("57e6cad2-b922-47af-8bc1-4d4b992517e4"), Type = TextBlockType.Text, Text = "One of the most useful pieces of cunning knowledge is the ability to notice the emotional echo of a soul that passed on, leaving a haunt in its wake. Even when you aren’t (action: Searching|Search) while in exploration mode, the GM rolls a secret check for you to notice haunts that usually require you to be (action: Searching|Search)." };
            yield return new TextBlock { Id = Guid.Parse("7eca77c6-801e-4861-b6a4-6dfc6e918b60"), Type = TextBlockType.Text, Text = "You can disable haunts that require master proficiency rank in a skill as long as you’re at least trained in the skill. If you have master proficiency in the skill, you can disable haunts that require a proficiency rank of legendary instead." };
            yield return new TextBlock { Id = Guid.Parse("7a860a1c-4f08-4149-bd2b-2913385f7cd3"), Type = TextBlockType.Text, Text = "While holding a lantern implement, you also gain a +1 circumstance bonus to Perception checks to find haunts, to AC against attacks made by haunts, and to saves against haunts. If you have the lantern implement’s adept benefit, the circumstance bonus is +2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("385cbaca-6b71-433c-85f8-22e272cf8217"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
