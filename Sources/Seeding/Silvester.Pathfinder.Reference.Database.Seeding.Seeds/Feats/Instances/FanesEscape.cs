using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FanesEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("9917d808-489f-4720-8eb3-1c6b6fa705de");

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
            yield return new TextBlock { Id = Guid.Parse("945acf3b-6dfa-4cad-a823-1ba6971f485c"), Type = TextBlockType.Text, Text = $"~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("5b694a04-aca4-4a3c-827d-d24ae03861b9"), Type = TextBlockType.Text, Text = $"A good getaway requires a good distraction. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a deck of cards and flip it in a fluttering explosion, causing you to become briefly hidden to all other creatures using vision as their precise sense, and then you {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)}. You have enough cover to {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} until the end of your turn. This leaves all of the cards from the deck scattered about the room; collecting them into a deck again takes several minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0234ca46-fd7a-4ece-a5a5-50159461179b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29870e0d-39db-4bfc-8a62-a28a415fc486"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
