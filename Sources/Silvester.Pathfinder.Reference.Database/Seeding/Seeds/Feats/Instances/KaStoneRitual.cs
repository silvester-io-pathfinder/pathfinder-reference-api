using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KaStoneRitual : Template
    {
        public static readonly Guid ID = Guid.Parse("5334f6d4-5314-44c7-894a-49685212810c");

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
            yield return new TextBlock { Id = Guid.Parse("32e400ca-78fa-4d4e-82dc-79524e9f949b"), Type = TextBlockType.Text, Text = "You inscribe your true name on your ka stone, as well as oaths to gods and pharaohs, and embed it in your forehead in a special ritual with a sphinx or with a living monolith who already has this feat. The ka stone is an invested magic item that you automatically invest each day. It can’t be removed without your permission, nor can it be dispelled, and you can never lose investiture in the ka stone. Its Bulk is negligible." };
            yield return new TextBlock { Id = Guid.Parse("5df06281-739c-4142-ba8f-eb3adf6b4f12"), Type = TextBlockType.Text, Text = "The ka stone grants you a +1 item bonus to saves against (trait: death) effects and (trait: negative) effects, which increases to +2 at 8th level, +3 at 14th level, and +4 at 20th level." };
            yield return new TextBlock { Id = Guid.Parse("9a371570-b694-4a39-9028-e8aacdd8b63d"), Type = TextBlockType.Text, Text = "~ Activate: TWO-ACTIONS (envision), or a different activation if otherwise specified; **Frequency** a number of times each day equal to the number of class feats you have from the Living Monolith archetype; **Effect** You cast (spell: enlarge) on yourself or use one of the other activated abilities granted by a later Living Monolith feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("34c37b06-1352-419c-bef8-479c69d495ae"), Feats.Instances.LivingMonolithDedication.ID);
            builder.Manual(Guid.Parse("2166d191-0f43-49af-9506-d4e7f7e11510"), "A sphinx or living monolith with this feat performs a ritual with you.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c480205a-8f2b-49b2-b074-ec5302c394d2"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
