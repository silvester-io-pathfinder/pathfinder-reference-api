using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonDiscipleDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0713560e-aac6-4c06-920f-44bb6d0a8aae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Disciple Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the dragon disciple archetype. If you later take the sorcerer archetype, you must choose the draconic bloodline.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28713c51-707d-4e4b-a064-8284125bfe7d"), Type = TextBlockType.Text, Text = "~ Access: You are a kobold with the dragonscaled or spellscaled heritage, a dragon instinct barbarian, or a draconic bloodline sorcerer." };
            yield return new TextBlock { Id = Guid.Parse("a209f35b-67f9-4d37-b414-3e35b2ce5cc2"), Type = TextBlockType.Text, Text = "You choose to study or worship one type of dragon, and your focus grants you a measure of its power. Choose one color of dragon when you select this feat; if you are a sorcerer with the draconic bloodline, this must be the same type as your bloodline. You gain resistance equal to half your level against one type of damage determined by the chosen dragon type. The GM may allow you to choose a dragon type not listed below, and will determine the damage type appropriate for that dragon." };
            yield return new TextBlock { Id = Guid.Parse("a48ce18d-b875-4d59-a7d3-8aac9179efa0"), Type = TextBlockType.Text, Text = "You also gain a +1 circumstance bonus to saving throws against (trait: sleep) effects and effects that would make you paralyzed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1c2cd86-455e-422d-83a3-22efea5b88aa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
