using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KaStoneRitual : Template
    {
        public static readonly Guid ID = Guid.Parse("d3045d16-49c8-4256-9dc7-cf0303d5d0f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ka Stone Ritual",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00decca8-ed3a-4c10-931b-913d3c586f05"), Type = TextBlockType.Text, Text = "You inscribe your true name on your ka stone, as well as oaths to gods and pharaohs, and embed it in your forehead in a special ritual with a sphinx or with a living monolith who already has this feat. The ka stone is an invested magic item that you automatically invest each day. It can’t be removed without your permission, nor can it be dispelled, and you can never lose investiture in the ka stone. Its Bulk is negligible." };
            yield return new TextBlock { Id = Guid.Parse("a28c2859-ca01-4c26-ac9d-587ad74de6db"), Type = TextBlockType.Text, Text = "The ka stone grants you a +1 item bonus to saves against (trait: death) effects and (trait: negative) effects, which increases to +2 at 8th level, +3 at 14th level, and +4 at 20th level." };
            yield return new TextBlock { Id = Guid.Parse("0a678c4e-f848-4a83-87f9-429a3bf23eee"), Type = TextBlockType.Text, Text = "~ Activate: TWO-ACTIONS (envision), or a different activation if otherwise specified; **Frequency** a number of times each day equal to the number of class feats you have from the Living Monolith archetype; **Effect** You cast (spell: enlarge) on yourself or use one of the other activated abilities granted by a later Living Monolith feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14891ed5-568f-4ca0-985d-9c6729899542"), Feats.Instances.LivingMonolithDedication.ID);
            builder.Manual(Guid.Parse("55b6598f-2617-4795-8e73-fc92e811aa4d"), "A sphinx or living monolith with this feat performs a ritual with you.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba6f1f10-bf8b-4687-94fe-a67bbfafe3f7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
