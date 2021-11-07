using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FanesEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("70192288-573a-4c41-9b71-39cf96673518");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fane's Escape",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70a63d6c-2ac3-4ce1-ba2d-df0eca16f4ae"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("7cf06223-94c8-4d8d-964c-5629bea3e1d0"), Type = TextBlockType.Text, Text = "A good getaway requires a good distraction. You (action: Interact) to draw a deck of cards and flip it in a fluttering explosion, causing you to become briefly hidden to all other creatures using vision as their precise sense, and then you (action: Sneak). You have enough cover to (action: Sneak) until the end of your turn. This leaves all of the cards from the deck scattered about the room; collecting them into a deck again takes several minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f5bf3342-7b63-4672-bdea-956447e852eb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3d89518-3daf-43db-bce9-1e8f946b8d76"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
